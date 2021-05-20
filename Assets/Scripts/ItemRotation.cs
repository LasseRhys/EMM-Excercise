using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    float speed = 200f;

  
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
