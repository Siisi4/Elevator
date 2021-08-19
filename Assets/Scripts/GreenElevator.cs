using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenElevator : MonoBehaviour
{
    public GameObject Green;
    public GameObject MyCube;
    public GameObject Light;
   
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Green"){
            Green.SetActive(true);
            MyCube.SetActive(false);
            Light.SetActive(false);
        }
     
    }
}
