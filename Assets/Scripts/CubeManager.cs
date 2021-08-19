using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // Si un object dans ma main est active, les hitbox cages invisibles autour des cubes seront activées.
    
    public GameObject MyRed;
    public GameObject MyPurple;
    public GameObject MyGreen;
    public GameObject MyBlue;

    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;


    // PARTIE 2 (pour ne pas faire 2 scripts et tout faire dans un manager unique)
    // On fait pareil mais pour les cubes sur l'elevator
    // Si un objet sur l'elevator est active, les hitbox cages invisibles seront activées.
    public GameObject ElevatorWalls;
    public GameObject Red;
    public GameObject Purple;
    public GameObject Green;
    public GameObject Blue;


    void Start()
    {
        
    }

    void Update()
    {
        if(MyRed.activeSelf || MyPurple.activeSelf || MyGreen.activeSelf || MyBlue.activeSelf){
            Wall1.SetActive(true);
            Wall2.SetActive(true);
            Wall3.SetActive(true);
            Wall4.SetActive(true);
        }else{
            
            Wall1.SetActive(false);
            Wall2.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(false);
            
        }

        if(Red.activeSelf || Purple.activeSelf || Green.activeSelf || Blue.activeSelf){
            ElevatorWalls.SetActive(true);

        }else{
            ElevatorWalls.SetActive(false);
        }
            
    }
}
