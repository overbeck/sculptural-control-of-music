using UnityEngine;
using System.Collections;

public class Send : MonoBehaviour
{

    public OSC osc;


    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OscMessage message = new OscMessage();
        message.address = "3333";
        message.values.Add(777);
        osc.Send(message);

    }



    
  
        
}