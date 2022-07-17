using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [Header("Driver Variables")]
    // Testing - SerializeField
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float slowSpeed;
    [SerializeField] float boostSpeed;
    [SerializeField] string roadTag;
    [SerializeField] string colliderTag;
    [SerializeField] string boostSpeedTag;
    //
    // Start is called before the first frame update
    void Start()
    {
        steerSpeed = 300f;
        moveSpeed = 20f;
        slowSpeed = 15f;
        boostSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -(Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime));
        transform.Translate(0, (Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime), 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collider){
        if(collider.gameObject.tag == colliderTag){
           moveSpeed = slowSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == boostSpeedTag){
          moveSpeed = boostSpeed;
        }

        if(collider.gameObject.tag == roadTag){
          // moveSpeed = 20f;
        }
    }
} 
