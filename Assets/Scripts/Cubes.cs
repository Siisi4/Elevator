using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubes : MonoBehaviour
{
    public GameObject CubeRed;

    public GameObject MyRedCube;

    //public Color MyColor;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player"){    

            // L'objet disparait 
            CubeRed.SetActive(false);
            // Mon cube prend la couleur de l'objet
            //MyCube.GetComponent<Renderer>().material.color = MyColor;
            MyRedCube.SetActive(true);
            Debug.Log("Object is picked up");
 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
