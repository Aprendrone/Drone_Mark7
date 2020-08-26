using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject drone;
    GameObject helice1;
    GameObject helice2;
    GameObject helice3;
    GameObject helice4;
    // Start is called before the first frame update
    void Start()
    {
        helice1 = drone.transform.GetChild(0).GetChild(0).gameObject;
        helice2 = drone.transform.GetChild(2).GetChild(0).gameObject;
        helice3 = drone.transform.GetChild(2).GetChild(0).gameObject;
        helice4 = drone.transform.GetChild(3).GetChild(0).gameObject;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
