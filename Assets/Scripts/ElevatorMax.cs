using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMax : MonoBehaviour
{
    public GameObject Elevator;
    //public GameObject limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("limit")){
            Elevator.transform.Translate(0f, -1f * Time.deltaTime, 0f);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
