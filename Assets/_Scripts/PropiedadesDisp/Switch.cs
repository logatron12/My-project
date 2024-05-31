using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool Encendido = false;
    public bool Power = false;
    public bool Consola = false;
    public bool serial1 = false;
    public bool serial2 = false;
    public bool CableLAN = false;
    public bool CableLAN2 = false;
    public bool CableLAN3 = false;
    public bool CableLAN4 = false;
    public bool CableLAN5 = false;
    public bool CableLAN6 = false;
    public bool CableLAN7 = false;
    public bool CableLAN8 = false;
    public bool CableLAN9 = false;
    public bool CableLAN10 = false;
    public bool CableLAN11 = false;
    public bool CableLAN12 = false;
    public bool CableLAN13 = false;
    public bool CableLAN14 = false;
    public bool CableLAN15 = false;
    public bool CableLAN16 = false;
    public bool CableLAN17 = false;
    public bool CableLAN18 = false;
    public bool CableLAN19 = false;
    public bool CableLAN20 = false;
    public bool CableLAN21 = false;
    public bool CableLAN22 = false;
    public bool CableLAN23 = false;
    public TakeObject to;
    public cajaCables cc;
    public Cables cable;
    public string Nombre;
    public int cont1 = 0;
    public int cont2 = 0;


    void Awake()
    {
        cable = GameObject.Find("Player").GetComponent<Cables>();
        to = GameObject.Find("hand").GetComponent<TakeObject>();
        
    }



    public void nuevo()
    {
        Nombre = gameObject.tag;
    }
    public void On()
    {
        cc = GameObject.Find("Interfaz").GetComponent<cajaCables>();
        if (Power == true) {

            cc.cont1 = cc.cont1 + 1;
            Encendido = true;
            cc.encendido(cc.cont1);

            //if ( cont1 == 0)
            //{
            // cc = GameObject.Find("R1").GetComponent<cajaCables>();
            //cc.R1(1);
            //cont1 = 1;

            //}
            //if (gameObject.tag == "Switch" && cont2 == 0)
            //{
            //cc = GameObject.Find("S1").GetComponent<cajaCables>();
            //cc.S1(1);
            //cont2 = 1;
            //}
            //if (gameObject.tag == "Router" && cont1 == 1)
            //{
            //cc = GameObject.Find("R1").GetComponent<cajaCables>();
            //cc.R2(1);


            //}
            //if (gameObject.tag == "Switch" && cont2 == 1)
            //{
            //cc = GameObject.Find("S1").GetComponent<cajaCables>();
            //cc.S2(1 );
            //
            //}

        }

    }
    public void Off()
    {
        Encendido = false;
    }

    public void rj1()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        if (gameObject.tag == "Router")
        {
            if (CableLAN == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (to.redlock == true)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN = true;
                    to.fase = 0;
                }


                else if (cable.playerLan == false && cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN = true;
                    to.fase = 0;
                }
            }
        }
    }
    public void console()
    {
   
        cc = GameObject.Find("CablesConsola").GetComponent<cajaCables>();
    
      
        if (Consola == false && to.consollock == true && cable.playerConsol == false)
        {
            if (cable.playerConsol2 == false)
            {
                to.fase = 1;
                cc.recogerconsola(to.fase);
                cable.playerConsol = true;
                Consola = true;
                to.fase = 0;
            }else if (cable.playerConsol2 == true)
            {
                to.fase = 3;
                cc.recogerconsola(to.fase);
                cable.playerConsol = true;
                Consola = true;
                to.fase = 0;
            }
        }
        
    }

    public void energia()
    {
        cc = GameObject.Find("CablesPower").GetComponent<cajaCables>();
        
        if (Power == true)
        {
            Power = false;
        }
       
        if (cable.playerPower == false)
        {
            to.fase = 1;
            cc.recogerpower(to.fase);

            Power = true;
            cable.playerPower2 = true;
            to.fase = 0;
        }
        else if (cable.playerPower == true)
        {
            to.fase = 3;
            cc.recogerpower(to.fase);

            Power = true;
            cable.playerPower2 = true;
            to.fase = 0;
        }


    }

    public void s1()
    {

        cc = GameObject.Find("CablesSerial").GetComponent<cajaCables>();

        //if (serial1 == true)
        //{
        //  cable.playerSerial = false;
        //serial1 = false;

        //}
        //else 
        if (cable.playerSerial == false && cable.playerSerial2 == true || cable.playerSerial == false && cable.playerSerial2 == false) {
            if (serial1 == false && to.seriallock == true)
            {
                if (cable.playerSerial2 == false)
                {
                    to.fase = 1;
                    cc.recogerserial(to.fase);
                    cable.playerSerial = true;
                    serial1 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
                else if (cable.playerSerial2 == true)
                {
                    to.fase = 3;
                    cc.recogerserial(to.fase);
                    cable.playerSerial = true;
                    serial1 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
            }
        }

        else if (cable.playerSerial2 == false && cable.playerSerial == true)
        {
            if (serial1 == false && to.seriallock == true && cable.playerSerial2 == false)
            {
                if (cable.playerSerial == false)
                {
                    to.fase = 2;
                    cc.recogerserial(to.fase);
                    cable.playerSerial2 = true;
                    serial1 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
                else if (cable.playerSerial == true)
                {
                    to.fase = 3;
                    cc.recogerserial(to.fase);
                    cable.playerSerial2 = true;
                    serial1 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
            }
        }

        cable.Tageo();


    }

    public void s2()
    {

        if (serial2 == true)
        {
            serial2 = false;
        }
        else if (serial2 == false)
        {
            serial2 = true;
        }
        cc = GameObject.Find("CablesSerial").GetComponent<cajaCables>();

        //if (serial2 == true)
        //{
        //  cable.playerSerial = false;
        //serial2 = false;

        //}
        //else 
        if (cable.playerSerial == false && cable.playerSerial2 == true || cable.playerSerial == false && cable.playerSerial2 == false)
        {
            if (serial2 == false && to.seriallock == true && cable.playerSerial == false)
            {
                if (cable.playerSerial2 == false)
                {
                    to.fase = 1;
                    cc.recogerserial(to.fase);
                    cable.playerSerial = true;
                    serial2 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
                else if (cable.playerSerial2 == true)
                {
                    to.fase = 3;
                    cc.recogerserial(to.fase);
                    cable.playerSerial = true;
                    serial2 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
            }
        }

        else if (cable.playerSerial2 == false && cable.playerSerial == true)
        {
            if (serial2 == false && to.seriallock == true && cable.playerSerial2 == false)
            {
                if (cable.playerSerial == false)
                {
                    to.fase = 2;
                    cc.recogerserial(to.fase);
                    cable.playerSerial2 = true;
                    serial2 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
                else if (cable.playerSerial == true)
                {
                    to.fase = 3;
                    cc.recogerserial(to.fase);
                    cable.playerSerial2 = true;
                    serial2 = true;
                    to.fase = 0;
                    Nombre = gameObject.tag;
                }
            }
        }

    }

    
    public void rj2()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN2 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN2 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if(CableLAN2 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN2 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN2 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN2 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN2 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN2 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj3()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN3 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN3 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN3 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN3 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN3 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (to.redlock == true)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN = true;
                    to.fase = 0;
                }


                else if (cable.playerLan == false && cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj4()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN4 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN4 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN4 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN4 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN4 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN4 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN4 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN4 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj5()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN5 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN5 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN5 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN5 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN5 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN5 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN5 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN5 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj6()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        
        if (gameObject.tag == "Router")
        {
            if (CableLAN6 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN6 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN6 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN6 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN6 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN6 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj7()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN7 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN7 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN7 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN7 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN7 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN7 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN7 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN7 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj8()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN8 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN8 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN8 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN8 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN8 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN8 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN8 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN8 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj9()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN9 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN9 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN9 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN9 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN9 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN9 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN9 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN9 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj10()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN10 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN10 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN10 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN10 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN10 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN10 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN10 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN10 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj11()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN11 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN11 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN11 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN11 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN11 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN11 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN11 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN11 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj12()
    {
        cc = GameObject.Find("CablesRed").GetComponent<cajaCables>();

        //if (CableLAN12 == true)
        //{
        //  cable.playerLan = false;
        //CableLAN12 = false;

        //}
        //else 
        if (gameObject.tag == "Router")
        {
            if (CableLAN12 == false && to.redlock == true && cable.playerLan == false)
            {
                if (cable.playerLan2 == false)
                {
                    to.fase = 1;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN12 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan2 == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan = true;
                    CableLAN12 = true;
                    to.fase = 0;
                }
            }
        }
        else if (gameObject.tag == "Switch")
        {
            if (CableLAN12 == false && to.redlock == true && cable.playerLan2 == false)
            {
                if (cable.playerLan == false)
                {
                    to.fase = 2;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN12 = true;
                    to.fase = 0;
                }
                else if (cable.playerLan == true)
                {
                    to.fase = 3;
                    cc.recogerred(to.fase);
                    cable.playerLan2 = true;
                    CableLAN12 = true;
                    to.fase = 0;
                }
            }
        }
    }

    public void rj13()
    {
        if (CableLAN13 == true)
        {
            CableLAN13 = false;
        }
        else if (CableLAN13 == false)
        {
            CableLAN13 = true;
        }
    }

    public void rj14()
    {
        if (CableLAN14 == true)
        {
            CableLAN14 = false;
        }
        else if (CableLAN14 == false)
        {
            CableLAN14 = true;
        }
    }

    public void rj15()
    {
        if (CableLAN15 == true)
        {
            CableLAN15 = false;
        }
        else if (CableLAN15 == false)
        {
            CableLAN15 = true;
        }
    }

    public void rj16()
    {
        if (CableLAN16 == true)
        {
            CableLAN16 = false;
        }
        else if (CableLAN16 == false)
        {
            CableLAN16 = true;
        }
    }
    public void rj17()
    {
        if (CableLAN17 == true)
        {
            CableLAN17 = false;
        }
        else if (CableLAN17 == false)
        {
            CableLAN17 = true;
        }
    }

    public void rj18()
    {
        if (CableLAN18 == true)
        {
            CableLAN18 = false;
        }
        else if (CableLAN18 == false)
        {
            CableLAN18 = true;
        }
    }
    public void rj19()
    {
        if (CableLAN19 == true)
        {
            CableLAN19 = false;
        }
        else if (CableLAN19 == false)
        {
            CableLAN19 = true;
        }
    }
    public void rj20()
    {
        if (CableLAN20 == true)
        {
            CableLAN20 = false;
        }
        else if (CableLAN20 == false)
        {
            CableLAN20 = true;
        }
    }
    public void rj21()
    {
        if (CableLAN21 == true)
        {
            CableLAN21 = false;
        }
        else if (CableLAN21 == false)
        {
            CableLAN21 = true;
        }
    }
    public void rj22()
    {
        if (CableLAN22 == true)
        {
            CableLAN22 = false;
        }
        else if (CableLAN22 == false)
        {
            CableLAN22 = true;
        }
    }
    public void rj23()
    {
        if (CableLAN23 == true)
        {
            CableLAN23 = false;
        }
        else if (CableLAN23 == false)
        {
            CableLAN23 = true;
        }
    }



    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
