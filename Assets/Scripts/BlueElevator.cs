using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueElevator : MonoBehaviour
{
    public GameObject blue;
    public GameObject MyCube;
    public GameObject Light;
   
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Blue"){
            blue.SetActive(true);
            MyCube.SetActive(false);
            Light.SetActive(false);
        }
     
    }
}
