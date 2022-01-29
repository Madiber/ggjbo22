using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string horizontalAxis;
    [SerializeField] string verticalAxis;
    [SerializeField] Input attackButton;
    [SerializeField] GameObject attackPrefab;

    private CharacterController characterController;
    private Animator animator;
    public float speed = 6;
    float turnSmoothVelocity;
    float turnSmoothTime = 0.1f;

    float horizontal;
    float vertical;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        horizontal = Input.GetAxis(horizontalAxis);
        vertical = Input.GetAxis(verticalAxis);
        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            characterController.Move(direction * speed * Time.deltaTime);
        }
        else
            characterController.Move(Vector3.zero);

        animator.SetFloat("speed", direction.magnitude);
    }
}