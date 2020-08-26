using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHelix : MonoBehaviour
{
    Rigidbody rb;
    Renderer rend;
    Vector3 rotacion;
    public bool sentidoHorario;
    public float lambda=25f;
    public float rps;
    float area= 3.1415f*50f;
    float p = 1.2f;
    public int step=200;
    public float fuerza;
    

    
    public void Forzar()
    {
        float power = ((0.150f*3.24f)/(250*250))*step*step;
        
        fuerza= Mathf.Pow(0.5f*p*area*power*power,(0.333333333f));
        /*print(step);
        #step+=1;
        #print(fuerza);*/
    } 
    // Start is called before the first frame update
    void Start()
    {
        area = 3.1415f*(PlayerPrefs.GetFloat("radio")*0.01f)*(PlayerPrefs.GetFloat("radio")*0.01f);
        print(area);
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<MeshRenderer>();
        //rb.angularVelocity= rotacion;
        
        //rb.rotation= Quaternion.identity;
        if (sentidoHorario)
        {
            rotacion = new Vector3 (0,360f*rps,0);
        }
        else
        {
            rotacion = new Vector3 (0,-360*rps,0);
        }
        /*
        int step=0;
        while (step<=120)
        {
            Forzar();
            step+=1;

        }*/
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = this.transform.up.normalized;
        //rb.angularVelocity= rotacion;
        //Vector3 center = rend.bounds.center;
        //transform.RotateAround(center,new Vector3 (0f,1f,0f), 90f*Time.deltaTime);
        transform.Rotate(rotacion * Time.deltaTime  ,Space.Self);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //print(step);
            Forzar();
            //print(fuerza);
            step+=1;
            if (step>250)
            {
                step=0;
            }
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Forzar();
            rb.AddForce(direccion*fuerza);
            /*
            step+=1;
            if(step == 250)
            {
                step = 0;
            }
            //print(rotacion);*/

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //print(step);
            //print(fuerza);

        }
        
    
        
    }
}
