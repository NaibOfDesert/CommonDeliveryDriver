using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [Header("Driver Variables")]
    // Testing - SerializeField
    [SerializeField] float steerSpeed = 1f;
    public float moveSpeed;
    //
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -(Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime));
        transform.Translate(0, (Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime), 0);
        
    }
}
