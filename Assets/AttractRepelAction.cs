using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (SphereCollider))]
public class AttractRepelAction : MonoBehaviour
{
    [SerializeField] KeyCode key;
    public float force;
    public float radius = 5;
    [SerializeField] Collider [] Colliders;

    private void Start()
    {
        GetComponent<SphereCollider>().radius = radius;
    }

    private void Update()
    {
        if (Input.GetKeyDown(key))
            Action();
    }

    private void Action()
    {
        Debug.Log("Boom");
        Colliders = Physics.OverlapSphere(transform.position, radius);
        Rigidbody r;
        foreach (Collider c in Colliders)
        {
            if(c.tag == "Pecora")
            {
                r = c.GetComponent<Rigidbody>();
                r.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
