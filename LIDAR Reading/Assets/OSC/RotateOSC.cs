using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RotateOSC : MonoBehaviour
{

    public float x,y,z; // we can change the speed value inside Unity because it's public
    public OSC osc; //reference to the OSC script

    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/RotateY" , OnRotateY);
        osc.SetAddressHandler("/RotateX" , OnRotateX);
        osc.SetAddressHandler("/RotateZ" , OnRotateZ);
    }

    void Update()
    {
        transform.Rotate(x, y, z); // this will make the obj rotate on the xyz axis
    }

    void OnRotateY(OscMessage message)
    {
        float yosc = message.GetFloat(0);
        y = yosc;
        
    }
    void OnRotateX(OscMessage message)
    {
        float xosc = message.GetFloat(0);
        x = xosc;

    }
    void OnRotateZ(OscMessage message)
    {
        float zosc = message.GetFloat(0);
        z = zosc;

    }

}