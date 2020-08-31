using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class LIDAR002 : MonoBehaviour
{
    public float maxRayDistance = 2000;

    void Start() 
    {
        
    
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Ray ray = new Ray(transform.position, Vector3.left);
        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.position + Vector3.left * maxRayDistance, Color.red);


        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {

            Debug.Log("You hit a ray");
            Debug.DrawLine(hit.point, hit.point + Vector3.up * 100, Color.green);
        }


    }
}
