using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    
    public  Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "RedE"){
            anim = gameObject.GetComponent<Animation>();
            anim.Start();
            Debug.Log("Animation");
        }
    }
    
}
