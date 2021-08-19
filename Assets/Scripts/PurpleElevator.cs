using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleElevator : MonoBehaviour
{
    
    public GameObject purpleEl;
    public GameObject MyCube;
    public GameObject Light;
   
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Purple"){
            purpleEl.SetActive(true);
            MyCube.SetActive(false);
            Light.SetActive(false);
        }
     
    }
}
