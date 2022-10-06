using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    private float turningSpeed = 180;
    //Transform head;
    bool allowRotate = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 headEuler = transform.rotation.eulerAngles;
        if (headEuler.y > 180)
        {
            headEuler.y -= 360;
        }
        float desiredRot = headEuler.y + ((0 * 1));
        //head = GetComponent<Transform>();

        if (Input.GetAxis("Mouse Y") < 0 && allowRotate)
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);

        if (Input.GetAxis("Mouse Y") > 0 && allowRotate)
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);

        //if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime * 5);

        //if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime * 5);

        //if ((GameObject.eulerAngles.z) >= 30f &&allowRotate)
            allowRotate = false;

        //if ((GameObject.eulerAngles.z) <= -30f &&allowRotate)
            allowRotate = false;

        //if (GameObject.eulerAngles.z < 30f)
            allowRotate = true;

        //if (GameObject.eulerAngles.z > -30f)
            allowRotate = true;

        //if ((head.transform.rotation.eulerAngles.x) == 30 && allowRotate)
        {
            allowRotate = false;
            print("test");
        }
        //else
            allowRotate = true;

        //if ((head.transform.rotation.eulerAngles.x) == -30 && allowRotate)
        {
            allowRotate = false;
            print("test");
        }
        //else
            allowRotate = true;

    }
}
