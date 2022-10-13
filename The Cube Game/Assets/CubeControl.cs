using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float damage;

    private float turningSpeed = 360;
    public float movementSpeed = 2.0f;
    bool allowJump = true;
    Rigidbody ourRigidBody;
    Vector3 startPosition;
    public GameObject target;
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
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ourRigidBody = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed * 15;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed * 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed * 10;
        }
        if (Input.GetKey(KeyCode.D))
        { 
            transform.position += transform.right * Time.deltaTime * movementSpeed * 10;
        }
        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(Vector3.down,turningSpeed * Time.deltaTime);

        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)&&allowJump)
        {
            ourRigidBody.AddForce(Vector3.up * 3000);
            allowJump = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
            transform.position = startPosition;
    }
}
