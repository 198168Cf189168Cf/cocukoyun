using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uzatma : MonoBehaviour
{
    public GameObject zemin;

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        Instantiate(zemin, zemin.transform.position + new Vector3(0, 0, 5), Quaternion.identity);
        Debug.Log("Zemin oluşturuldu!");
    }
}
