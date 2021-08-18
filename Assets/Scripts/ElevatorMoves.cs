using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElevatorMoves : MonoBehaviour
{
    public GameObject UIText;
    public GameObject Elevator;
    // Start is called before the first frame update
    
    void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")){
            UIText.SetActive(true);
            if(Input.GetKey(KeyCode.E))
            Elevator.transform.Translate(0f, 1f * Time.deltaTime, 0f);
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            UIText.SetActive(false);
        }
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
