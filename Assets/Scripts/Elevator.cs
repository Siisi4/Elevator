using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject redEl;
    public GameObject MyCube;
    //public Animation anim;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Red"){
            redEl.SetActive(true);
            Destroy(MyCube);
        }
        //if(collider.gameObject.tag == "RedE"){
        //    anim.Play();
        //    Debug.Log("Elevator animation");
        //}
    }


}
