using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LimitDeleter : MonoBehaviour
{

    // A attacher à la limite
    // Lorsqu'un des cubes (qu'on check avec tag) sur l'elevator atteint cette limite
    // --> alors le cube se désactive.
    
    public Transform limit;
    public GameObject Cube;

    void Start() {
        
    }
    
    void FixedUpdate() {
        Vector3 a = transform.position;
        Vector3 b = limit.position;
        if(Vector3.Distance(transform.position, limit.position) <= 1){
            Cube.SetActive(false);

        }
    }
    
}
