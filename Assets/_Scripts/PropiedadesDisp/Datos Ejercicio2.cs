using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEjercicio2 : MonoBehaviour
{
    public bool win1;
    public bool win2;

    public cajaCables cc;
    Interp inp;
    Terminar T;
  //  asignarip ip;
    

    public void check()
    {
        cc = GameObject.Find("Interfaz").GetComponent<cajaCables>();
        // ip = GameObject.Find("ipconfig").GetComponent<asignarip>();

        if (cc.consola == true && cc.red == true && cc.serial == true && cc.power == true)
        {
            win1 = true;
        }

        

        inp = GetComponent<Interp>();
        if (inp.eigrp1 == true && inp.eigrp2 == true && inp.eigrp3 == true && inp.eigrp4 == true)
        {
            win2 = true;
        }
        if (win1 == true && win2 == true)
        {
            Ganador();
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
        check();


    }


    public void Ganador()
    {
        T = GameObject.Find("Premio").GetComponent<Terminar>();
        T.Final();
    }

}
