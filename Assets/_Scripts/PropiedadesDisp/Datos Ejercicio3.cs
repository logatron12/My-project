using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEjercicio3 : MonoBehaviour
{
    public bool win1;
    public bool win2;
    public cajaCables cc;
    Interp inp;
    Terminar T;

    

    public void check()
    {
        cc = GameObject.Find("CablesConsola").GetComponent<cajaCables>();
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();
        cc = GameObject.Find("CablesPower").GetComponent<cajaCables>();
        cc = GameObject.Find("CablesSerial").GetComponent<cajaCables>();
       // ip = GameObject.Find("ipconfig").GetComponent<asignarip>();

        if (cc.consola == true && cc.red == true && cc.serial == true && cc.power == true)
        {
            win1 = true;
        }

        

        inp = GetComponent<Interp>();
        if (inp.tr1 == true && inp.tr2 == true && inp.tr3 == true)
        {
            win2 = true;
        }

        if (win1 == true && win2 == true)
        {
            Ganador();
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void Ganador()
    {
        T = GameObject.Find("Premio").GetComponent<Terminar>();
        T.Final();
    }

}