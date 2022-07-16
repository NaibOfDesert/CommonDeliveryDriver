using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider) 
    {
        Debug.Log("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("Collider - trigger!");
    }

    private void OnTriggerExit2D(Collider2D collider) 
    {
         
    }
}
