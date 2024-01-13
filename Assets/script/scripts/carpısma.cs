using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class carpısma : MonoBehaviour
{
    public GameObject oyunbittipanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider obj){
       if (obj.gameObject.CompareTag("dogru")){
      Debug.Log ("tekrar deneyin!");
      Destroy (obj.gameObject); 
      oyunbittipanel.SetActive(true);
      Time.timeScale = 0;
       }
      if (obj.gameObject.CompareTag("yanlis")){
      Debug.Log ("bravo");
      Destroy (obj.gameObject);
      }
        
    }


    public void TekrarBasla()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
