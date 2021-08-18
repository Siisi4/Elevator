using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // Si un object dans ma main est active, les hitbox cage invisible autour des cubes seront activées.
    
    public GameObject MyRed;
    public GameObject MyPurple;
    public GameObject MyGreen;
    public GameObject MyBlue;

    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            
    }
}
