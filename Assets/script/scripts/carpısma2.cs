using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpısma2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider obj){
        
      if (obj.gameObject.CompareTag("anahtar2")){
      Debug.Log ("HAY ALLAHHH");
      Destroy (obj.gameObject);
      }
        
    }
}
