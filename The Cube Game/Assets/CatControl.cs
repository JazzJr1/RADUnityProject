using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float damage;
    bool animOn = true;
    private float turningSpeed = 180;
    public float movementSpeed = 2.0f;
    bool allowJump = true;
    Rigidbody ourRigidBody;
    Vector3 startPosition;
    public int bells;
    public GameObject cat;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            allowJump = true;
            animOn = true;
            cat.GetComponent<Animator>().Play("Idle_A");
        }
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            startPosition = transform.position;
        }
        if (collision.gameObject.CompareTag("Bell"))
        {
            Destroy(collision.gameObject);
            bells += 1;

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

        if (Input.GetKey(KeyCode.W)&&animOn)
        {
            cat.GetComponent<Animator>().Play("Walk");
        }

        if (Input.GetKey(KeyCode.S) && animOn)
        {
            cat.GetComponent<Animator>().Play("Walk");
        }
        if (Input.GetKey(KeyCode.A) && animOn)
        {
            cat.GetComponent<Animator>().Play("Walk");
        }

        if (Input.GetKey(KeyCode.D) && animOn)
        {
            cat.GetComponent<Animator>().Play("Walk");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            cat.GetComponent<Animator>().Play("Idle_A");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            cat.GetComponent<Animator>().Play("Idle_A");
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed * 3;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            cat.GetComponent<Animator>().Play("Idle_A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            cat.GetComponent<Animator>().Play("Idle_A");
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
            transform.Rotate(Vector3.down,turningSpeed * Time.deltaTime);

        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)&&allowJump)
        {
            ourRigidBody.AddForce(Vector3.up * 1200);
            cat.GetComponent<Animator>().Play("Run");
            allowJump = false;
            animOn = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
            transform.position = startPosition;
    }
}
