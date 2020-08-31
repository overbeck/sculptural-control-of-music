using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class LIDAR002_2 : MonoBehaviour
{
    public float maxRayDistance = 2000;
    public OSC osc;

    // Update is called once per frame
    void FixedUpdate()
    {
        // creates new Raycast
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //when Raycast collides with mesh
        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {
            float d = hit.distance; //assign distance to variable d
            Debug.Log("You hit a ray ");
            Debug.Log(d);
            
            // red raycast trajectory
            Debug.DrawLine(transform.position, hit.point, Color.red); 
            //green vertical line from collision point
            Debug.DrawLine(hit.point, hit.point + Vector3.up * 100, Color.green);

            //OSC distance message sent on port 3333 
            OscMessage message = new OscMessage();
            message.address = "3333";
            message.values.Add(d);
            osc.Send(message);
           }
    }
    
}
