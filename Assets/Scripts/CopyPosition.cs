using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    [SerializeField]
    public Vector3 offset;

    [SerializeField]
    public Vector3 offsetRot;

    
    void Update()
    {
        transform.position = target.transform.position + Quaternion.Slerp(transform.rotation, target.transform.rotation, 100) * offset;
        transform.rotation = target.transform.rotation * Quaternion.Euler(offsetRot);
    }
}