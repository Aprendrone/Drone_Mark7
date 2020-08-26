using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Texto : MonoBehaviour
{
    // Start is called before the first frame update
    float step1;
    float step2;
    float step3;
    float step4;
    public GameObject helice1;
    public GameObject helice2;
    public GameObject helice3;
    public GameObject helice4;
    TextMeshProUGUI texto;

    void Start()
    {
        texto = this.gameObject.GetComponent<TextMeshProUGUI>();
        step1 = helice1.GetComponent<RotateHelix>().step;
        step2 = helice2.GetComponent<RotateHelix>().step;
        step3 = helice3.GetComponent<RotateHelix>().step;
        step4 = helice4.GetComponent<RotateHelix>().step;

        
    }

    // Update is called once per frame
    void Update()
    {
        step1 = helice1.GetComponent<RotateHelix>().step;
        step2 = helice2.GetComponent<RotateHelix>().step;
        step3 = helice3.GetComponent<RotateHelix>().step;
        step4 = helice4.GetComponent<RotateHelix>().step;

        texto.text = "Potencia M1 = "+ step1.ToString()+" \n Potencia M2 = "+ step2.ToString()+"\n Potencia M3 = "+ step3.ToString()+"\n Potencia M4 = "+ step4.ToString();
        
        
    }
}
