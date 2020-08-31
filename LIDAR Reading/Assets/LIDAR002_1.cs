using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class LIDAR002_1 : MonoBehaviour
{
    public float maxRayDistance = 2000;

    
    void Start()
    {


    }
    // Update is called once per frame
    void FixedUpdate()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {
            float d = hit.distance;
            Debug.Log("You hit a ray ");
            Debug.Log(d);

            Debug.DrawLine(transform.position , hit.point , Color.red);
            Debug.DrawLine(hit.point, hit.point + Vector3.up * 100, Color.green);
        }


    }
}
