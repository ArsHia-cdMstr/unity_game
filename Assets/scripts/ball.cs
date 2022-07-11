using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public int f;
         Material m4,m3,m2;
         public Transform explo;

    // Start is called before the first frame update
    void Start()
    {

        GameObject[] bricks= GameObject.FindGameObjectsWithTag("brick");
         foreach(GameObject brick in bricks){
          if(brick.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m4") m4 =brick.gameObject.GetComponent<Renderer>().sharedMaterial;
            if(brick.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m3") m3 =brick.gameObject.GetComponent<Renderer>().sharedMaterial;
              if(brick.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m2") m2 =brick.gameObject.GetComponent<Renderer>().sharedMaterial;
         }
          rb.AddForce(0,0,f*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnCollisionEnter(Collision other){ 


        if(other.gameObject.tag=="brick")

          {
            if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m5"){
             other.gameObject.GetComponent<Renderer>().material=m4;
              }

             else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m4"){     
             other.gameObject.GetComponent<Renderer>().material=m3;
              }

             else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m3"){
                other.gameObject.GetComponent<Renderer>().material=m2;
                }

              else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m2"){
                Destroy(other.gameObject);
                    Instantiate(explo,other.transform.position,other.transform.rotation);
                    
                }
            
            
              
          rb.AddForce(0,0,-2*f*Time.deltaTime);
          }

        else if(other.gameObject.tag=="player")
              rb.AddForce(0,0,f*Time.deltaTime);

    else if(other.gameObject.tag=="bottom"){
      Debug.Log("bottom");
    rb.AddForce(1*f*Time.deltaTime,0,0);

       GameObject[] bricks= GameObject.FindGameObjectsWithTag("brick");
        foreach(GameObject brick in bricks){

            brick.transform.position+=new Vector3(0,0,-20);
        }
      GameObject duplicate=GameObject.FindGameObjectWithTag("brick");

      GameObject brick0=Instantiate(duplicate);
      brick0.transform.position=new Vector3(-72,-40,270);

       GameObject brick1=Instantiate(duplicate);
      brick1.transform.position=new Vector3(-37,-40,270);

       GameObject brick2=Instantiate(duplicate);
      brick2.transform.position=new Vector3(-2,-40,270);

       GameObject brick3=Instantiate(duplicate);
      brick3.transform.position=new Vector3(33,-40,270);
    
    }


         
         

            else if(other.gameObject.tag=="rightWall")
rb.AddForce(-1*f * Time.deltaTime,0,0);

            else if(other.gameObject.tag=="leftWall")
rb.AddForce(f * Time.deltaTime,0,0);

            else if(other.gameObject.tag=="topWall")
rb.AddForce(0,0,-1*f * Time.deltaTime);

            else if(other.gameObject.tag=="downWall")
Debug.Log("gameOver");
  GameObject ball=GameObject.FindGameObjectWithTag("ball");

    }
}
