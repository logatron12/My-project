using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObject : MonoBehaviour
{

    public GameObject handPoint;
    private GameObject pickedObject = null;
    public bool redlock = false;
    public bool powerlock = false;
    public bool consollock = false;
    public bool seriallock = false;
    public float fase = 0;
    public menudispositivo md;
    public cajaCables cc;
    public Cables cable;
    public PC pc;
    public TerminalManager t;
    public MenuInterfaz mi;
    public asignarip ip;

    public void Awake()
    {
        cc = GameObject.Find("Interfaz").GetComponent<cajaCables>();
    }

    public void reutilizarc()
    {
        consollock = false;
    }


    // Update is called once per frame
    void Update()
    {

        if (pickedObject != null)
        {
            if (Input.GetKey("r"))
            {
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {

        // Mover dispositivo o entrar a la interfaz del dispositivo --------------------------------



        if (other.gameObject.CompareTag("Router") || other.gameObject.CompareTag("Switch") || other.gameObject.CompareTag("Objeto"))
        {
            if(Input.GetKey("e") && pickedObject == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = handPoint.transform.position;

                other.gameObject.transform.SetParent(handPoint.gameObject.transform);

                pickedObject = other.gameObject;
            }
            else if (Input.GetKey("q") && pickedObject == null)
            {
                string nombreDispositivo = gameObject.name;
                bool iniciar = true;
                md=other.gameObject.GetComponent<menudispositivo>();
                md.Abrimenu(iniciar);
 
            }
        }
        if (other.gameObject.CompareTag("Switch"))
        {
            if (Input.GetKey("q") && md.Pausa == true)
            {
                md.Pausa = false;   

            }
        }


        // Recogida de cables de cajas de cables ----------------------------------------------------



        if (other.gameObject.CompareTag("Power"))
        {
            if (Input.GetKey("e") && pickedObject == null && powerlock == false)
            {
                cc=other.gameObject.GetComponent<cajaCables>();
                cc.recogerpower(fase);
                powerlock = true;
                GameObject.Find("Player").GetComponent<Cables>().playerPower = false;
                GameObject.Find("Player").GetComponent<Cables>().playerPower2 = false;


            }
        }else if (other.gameObject.CompareTag("Consola"))
        {
            if (Input.GetKey("e") && pickedObject == null && consollock == false)
            {
                cc = other.gameObject.GetComponent<cajaCables>();
                cc.recogerconsola(fase);
                consollock = true;
                GameObject.Find("Player").GetComponent<Cables>().playerConsol = false;
                GameObject.Find("Player").GetComponent<Cables>().playerConsol2 = false;

            }
        }else if (other.gameObject.CompareTag("Red"))
        {
            if (Input.GetKey("e") && pickedObject == null && redlock == false)
            {
                cc = other.gameObject.GetComponent<cajaCables>();
                cc.recogerred(fase);
                redlock = true;
                GameObject.Find("Player").GetComponent<Cables>().playerLan = false;
                GameObject.Find("Player").GetComponent<Cables>().playerLan2 = false;

            }
        }
        else if (other.gameObject.CompareTag("Serial"))
        {
            if (Input.GetKey("e") && pickedObject == null && seriallock == false)
            {
                cc = other.gameObject.GetComponent<cajaCables>();
                cc.recogerserial(fase);
                seriallock = true;
                GameObject.Find("Player").GetComponent<Cables>().playerSerial = false;
                GameObject.Find("Player").GetComponent<Cables>().playerSerial2 = false;


            }
        }

        //conexion cable consola al Pc--------------------------------------------------------------

        if (other.gameObject.CompareTag("Pc"))
        {
            pc = other.gameObject.GetComponent<PC>();
            cable = GameObject.Find("Player").GetComponent<Cables>();
            cc = GameObject.Find("CablesConsola").GetComponent<cajaCables>();

            if (Input.GetKey("e") && cable.playerConsol2 == false && consollock == true && pc.consolecable == false)
            {

                if (cable.playerConsol == false)
                {
                    fase = 2;
                    cc.recogerconsola(fase);
                    
                    pc.cableconsola();
                    cable.playerConsol2 = true;
                    fase = 0;

                }else if (cable.playerConsol == true)
                {
                    fase = 3;
                    cc.recogerconsola(fase);
                   
                    pc.cableconsola();
                    cable.playerConsol2 = true;
                    fase = 0;
                }
            }
            else if (Input.GetKey("q") && pickedObject == null)
            {
                
                bool iniciar = true;               
                t = other.gameObject.GetComponent<TerminalManager>();
                t.Abrimenu(iniciar);
                mi = GameObject.Find("Interfaz").GetComponent<MenuInterfaz>();
                mi.Resumir();

            }
            else if (Input.GetKey("r") && pickedObject == null)
            {

                bool iniciar = true;
                ip = other.gameObject.GetComponent<asignarip>();
                ip.Abrimenu(iniciar);
                mi = GameObject.Find("Interfaz").GetComponent<MenuInterfaz>();
                mi.Resumir();

            }
        }
        if (other.gameObject.CompareTag("Port"))
        {
            if (Input.GetKey("e") && pickedObject == null && powerlock == true)
            {
                // con = other.gameObject.GetComponent<HPhysic.Connector.CableColor.Green>() ;
                // con.GetComponent<HPhysic.Connector.CableColor.Green>();
                cc = GameObject.Find("CablesPower").GetComponent<cajaCables>();
                if (cable.playerPower2 == false)
                {
                    fase = 2;
                    cc.recogerpower(fase);

                    
                    cable.playerPower = true;
                    fase = 0;
                }
                else if (cable.playerPower2 == true)
                {
                    fase = 3;
                    cc.recogerpower(fase);

                 
                    cable.playerPower = true;
                    fase = 0;
                }
                



            }
        }
        if (other.gameObject.CompareTag("Ganar"))
        { 
            if (Input.GetKey("e"))
            {
                GameObject.Find("Player").GetComponent<DatosEjercicio>().check();
            }


        }
    }
}
