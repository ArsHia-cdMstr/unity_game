using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
  public Vector3 ro;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag=="brick"){
            if(other.gameObject.GetComponent<Renderer>().sharedMaterial==transform.gameObject.GetComponent<Renderer>().sharedMaterial){
             
              if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m5"){
             other.gameObject.GetComponent<Renderer>().material=m4;
             Destroy(transform.gameObject);
              }

             else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m4"){     
             other.gameObject.GetComponent<Renderer>().material=m3;
              Destroy(transform.gameObject);
              }

             else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m3"){
                other.gameObject.GetComponent<Renderer>().material=m2;
                 Destroy(transform.gameObject);
                }

              else if(other.gameObject.GetComponent<Renderer>().sharedMaterial.name=="m2"){
                Destroy(other.gameObject);
                 Destroy(transform.gameObject);
                 Instantiate(explo);
                 explo.position=other.transform.position;
            explo.rotation=Quaternion.Euler(ro);
                }
                }
        }
    }
}
