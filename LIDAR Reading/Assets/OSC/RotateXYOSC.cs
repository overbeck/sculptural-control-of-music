using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class RotateXYOSC : MonoBehaviour
{

    public OSC osc; //reference to the OSC script
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
        osc.SetAddressHandler("/RotateX", OnRotateX);


    }

    void Update()
    {
        transform.Rotate(x, 0, 0, Space.Self);
    }


    void OnRotateX(OscMessage message)
    {
        
       // x = message.GetFloat(0);
        transform.Rotate(x, 0, 0, Space.Self); // this will make the obj rotate on the y axis
    }

}