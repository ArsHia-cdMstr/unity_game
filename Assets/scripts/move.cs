using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int f;
    public  Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(f*2*Time.deltaTime,0,0);
        }
         if (Input.GetKey("a"))
        {
            rb.AddForce(-1*f*2*Time.deltaTime,0,0);
        }
    }
}
