using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotationThrust = 250f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();//test123
    }

    void ProcessThrust(){
        if(Input.GetKey(KeyCode.Space)){
            rb.AddRelativeForce(Vector3.up * mainThrust *  Time.deltaTime);
        }
    }

    void ProcessRotation(){
        rb.freezeRotation = true; //Freeze rotation so we can manually rotate
        Vector3 rotation = Vector3.forward * rotationThrust * Time.deltaTime;

        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(rotation);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.Rotate(-rotation);
        }
        rb.freezeRotation = false;
    }

}
