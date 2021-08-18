using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMax : MonoBehaviour
{
    public Transform target;
    //public float t;
    public float speed;
    
    //public GameObject Elevator;
    public Transform limit;
    // Start is called before the first frame update
    void Start()
    {
    }

    //private void OnTriggerEnter(Collider other) {
    //    if(other.CompareTag("limit")){
    //        Elevator.transform.Translate(0f, -1f * Time.deltaTime, 0f);
    //    }
    //}
    
    void FixedUpdate() {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        if(Vector3.Distance(transform.position, limit.position) <= 5){
            transform.position = Vector3.MoveTowards(a, b, speed);
            Debug.Log("hitted max");
        }
        
    }
    
    // Update is called once per frame
    
}
