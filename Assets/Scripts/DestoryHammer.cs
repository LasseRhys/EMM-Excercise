using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryHammer : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag.Equals("Collectable"))
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log(score);
        }
      

    }


}