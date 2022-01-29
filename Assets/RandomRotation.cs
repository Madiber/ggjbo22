using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Quaternion.Euler(  transform.rotation.x,
                                                Random.RandomRange(0, 360),
                                                transform.rotation.z);
    }
}
