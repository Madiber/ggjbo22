using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSizeRot : MonoBehaviour
{
    [SerializeField] bool changeSize = false;
    public float minSize = 1;
    public float maxSize = 1.5f;
    [SerializeField] bool changeRot = false;

    private void Start()
    {
        if(changeRot)
            transform.rotation = Quaternion.Euler(  transform.rotation.x,
                                                Random.Range(0, 360),
                                                transform.rotation.z);

        if (changeSize)
        {
            float r = Random.Range(minSize, maxSize);
            transform.localScale = new Vector3(r, r, r);
        }
    }
}
