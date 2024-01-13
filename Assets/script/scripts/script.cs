using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
   private Rigidbody rb;
   public float speed= 1000f;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        
    

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move(){
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(Vector3.forward *(speed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(Vector3.right *(speed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(Vector3.back *(speed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(Vector3.left *(speed * Time.deltaTime));
        }


    }
    
}
