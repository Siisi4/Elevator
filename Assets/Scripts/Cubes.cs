using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubes : MonoBehaviour
{
    int OnOff = 0;
    public GameObject CubeRed;
    public GameObject MyCube;
    public Color MyColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Player" || OnOff == 0){

            // L'objet disparait 
            CubeRed.SetActive(false);
            // On a qqch en main
            OnOff += 1;
            // Mon cube prend la couleur de l'objet
            MyCube.GetComponent<Renderer>().material.color = MyColor;
            

            Debug.Log("Object is picked up");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
