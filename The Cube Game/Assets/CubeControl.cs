using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float turningSpeed = 180;
    public float movementSpeed = 2.0f;
    bool allowJump = true;
    Rigidbody ourRigidBody;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            allowJump = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ourRigidBody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed * 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed * 2;
        }
        if (Input.GetKey(KeyCode.D))
        { 
            transform.position += transform.right * Time.deltaTime * movementSpeed * 2;
        }
        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(Vector3.down,turningSpeed * Time.deltaTime * 2);

        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime * 2);

        if (Input.GetKeyDown(KeyCode.Space)&&allowJump)
        {
            ourRigidBody.AddForce(Vector3.up * 300);
            allowJump = false;
        }
    }
}
