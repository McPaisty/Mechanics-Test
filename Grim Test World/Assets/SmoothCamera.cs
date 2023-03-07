using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;
    bool deadZone = false;

    private Vector3 velocity = Vector3.zero;

     void FixedUpdate()
    {
        /*if (target.transform.position.y < 2.8f)
        {
            deadZone = true;
        }

        if (target.transform.position.y > 2.8f)
        {
            deadZone = false;
        }*/
    }
    void LateUpdate()
    {
        if (deadZone == false)
        {
            Vector3 movePosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
            Debug.Log("Deadzone false is being ran" + deadZone);
        }

        /*if (deadZone == true)
        {
            Vector3 movePosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
            transform.position = new Vector3(smoothedPosition.x, 2.8f, transform.position.z);
            Debug.Log("Deadzone true is being ran" + deadZone);
        }*/
    }
}

