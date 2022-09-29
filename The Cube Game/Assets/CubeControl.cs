using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float turningSpeed = 180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position -= Vector3.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position -= Vector3.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        { 
            transform.position += Vector3.right * Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, -30), 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down,turningSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up,turningSpeed * Time.deltaTime);

    }
}
