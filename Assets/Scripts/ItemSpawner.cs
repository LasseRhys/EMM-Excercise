using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField]
    public Transform myPrefab;

    
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            int randomPos = UnityEngine.Random.Range(-10, 10);
            int randomPosZ = UnityEngine.Random.Range(-10, 10);
            Instantiate(myPrefab, new Vector3(i + randomPos, 1, i + randomPosZ), Quaternion.Euler(0, 0, -90f));
        }
    }
}