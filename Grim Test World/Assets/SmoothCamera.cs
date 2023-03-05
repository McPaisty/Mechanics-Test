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

    private void FixedUpdate()
    {
        if (target.position.y < 2.5f && target.position.x <= 0 && target.position.x >= 0)
        {
            deadZone = true;
        }
    }
    void LateUpdate()
    {
        if (deadZone == false)
        {
            Vector3 movePosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
        }

        if (deadZone == true)
        {
            Vector3 movePosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
            transform.position = new Vector3(smoothedPosition.x, 2.8f, transform.position.z);
        }
    }
}

