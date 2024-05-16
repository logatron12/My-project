using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interp : MonoBehaviour
{
    public Cables c;
    public Switch s;
    public Text texto1;
    public Text texto2;
    private Text nombre;
    public bool enable = false;
    public Text cambio;
    public bool int1;
    public bool int2;
    public bool int3;
    public bool int4;
    public Text cambio3;
    public Text cambio4;
    public bool rip1;
    public bool rip2;
    public bool rip3;
    public bool rr;
    public bool eigrp1;
    public bool eigrp2;
    public bool eigrp3;
    public bool eg;
    public bool tr1;
    public bool tr2;
    public bool tr3;
    public int cont = 0;

    List<string> response = new List<string>();

    private void Awake()
    {
        c = GameObject.Find("Player").GetComponent<Cables>();
        s = GameObject.FindWithTag("Router").GetComponent<Switch>();

    }

    private void Start()
    {
        
        //  GameObject.Find("Pantalla").GetComponent<Interp>();
        if (c.nombre == "Switch")
        {

            texto2.text = "Switch> ";
            texto1.text = "Switch> ";

        }
        else if (c.nombre == "Router")
        {
            texto2.text = "Router> ";
            texto1.text = "Router> ";
        }
        Debug.Log("TerminalManager started");
    }



    public List<string> Interpret(string userInput)
    {
        response.Clear();

        if (c.playerConsol == true && c.playerConsol2 == true && s.Encendido)
        {

            Debug.Log("Menu opened");
            string[] args = userInput.Split();

         
            if (args[0] == "enable")
            {
                
                Debug.Log("Menu opened");
                enable = true;
                response.Add("El modo configuracion ha sido habilitado");
                
                return response;

            }

            if (args[0] == "config_t")
            {
                
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " asqweqdd";

                //response.Add("Enter configuration commands, one per line.  No End with CNTL/Z.");

             /*   if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "  Switch#   ";

                }
                else if (c.nombre == "Router")
                {
                    Debug.Log("Menu opened");
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "  Router#   ";

                }
             */

                response.Add("Has accedido exitosamente a la configuracion de la terminal");
                
                return response;

            }

            if (args[0] == "Interface_fa0/0" || args[0] == "Interface_fa0/1")
            {
                
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " asdaewrwdd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";

                }

                response.Add("Has accedido exitosamente a la configuracion de la interface FastEthernet");
                
                return response;
            }

            if (args[0] == "ip_add_192.168.20.1_255.255.255.0" || args[0] == "ip_add_200.200.200.1_255.255.255.0" || args[0] == "ip_add_192.168.30.1_255.255.255.0" || args[0] == "ip_add_192.168.2.1_255.255.255.0" || args[0] == "ip_add_192.168.1.1_255.255.255.0")
            {
                
                if (args[0] == "ip_add_192.168.20.1_255.255.255.0")
                {
                    int3 = true;
                }
                if (args[0] == "ip_add_200.200.200.1_255.255.255.0")
                {
                    int4 = true;
                }
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfdfhddd";
              /*  if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
              */
                response.Add("Has asignado exitosamente la ip a la interface");

                return response;
            }
            if (args[0] == "no_shutdown")
            {
                
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfhhhddd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                response.Add("La interfaz se ha activado");

                return response;
            }
            if (args[0] == "exit")
            {
                
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfddrd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                response.Add("Saliste de la configuracion de la configuracion de la interface FastEthernet");

                return response;
            }
            if (args[0] == "interface_se0/0/0")
            {
                
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " qqfiidd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                response.Add("Has accedido exitosamente a la configuracion de la interface Serial");

                return response;
            }
            if (args[0] == "ip_add_10.10.10.1_255.0.0.0" || args[0] == "ip_add_10.10.10.2_255.0.0.0")
            {
                
                if (args[0] == "ip_add_10.10.10.1_255.0.0.0")
                {
                    int1 = true;
                }
                if (args[0] == "ip_add_10.10.10.2_255.0.0.0")
                {
                    int2 = true;
                }
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfggddd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";

                };
                response.Add("Has asignado exitosamente la ip a la interface Serial");

                return response;
            }
            if (args[0] == "router_rip" && c.nombre == "Router")
            {
                
                rr = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsaf8seag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";


                response.Add("Accediste a la configuracion del router RIP");

                return response;
            }
            if (args[0] == "network_192.168.1.0" && rr == true || args[0] == "network_192.168.2.0" && rr == true || args[0] == "network_162.16.0.0" && rr == true)
            {
                
                if (args[0] == "network_192.168.1.0")
                {
                    rip1 = true;
                }
                if (args[0] == "network_192.168.2.0")
                {
                    rip2 = true;
                }
                if (args[0] == "network_162.16.0.0")
                {
                    rip3 = true;
                }

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsa78asdafseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Red configurada");

                return response;
            }
            if (args[0] == "version_2" && rr == true)
            {
                
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdad451safseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Estableciste la version del router RIP");

                return response;
            }
            if (args[0] == "no_auto-summary")
            {
                

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsafseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Accediste a la configuracion del router RIP");

                return response;
            }
            if (args[0] == "router_eigrp_10" && c.nombre == "Router")
            {
                
                eg = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsaf8seag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";


                response.Add("Accediste a la configuracion del router EIGRP");

                return response;
            }
            if (args[0] == "network_172.16.30.0" && eg == true || args[0] == "network_172.16.0.0" && eg == true || args[0] == "network_10.10.10.0" && eg == true)
            {
                
                if (args[0] == "network_172.16.30.0")
                {
                    eigrp1 = true;
                }
                if (args[0] == "network_172.16.0.0")
                {
                    eigrp2 = true;
                }
                if (args[0] == "network_10.10.10.0")
                {
                    eigrp3 = true;
                }

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsa78asdafseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Red configurada");

                return response;
            }
            if (args[0] == "switchport_mode_trunk" && c.nombre == "Switch")
            {
                
                tr1 = true;

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdasasad451safseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#";


                response.Add("Configuraste el puerto en modo trunk");

                return response;
            }
            if (args[0] == "switchport_trunk_native_vlan_99" && c.nombre == "Switch")
            {
                
                tr2 = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " 451safseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#";


                response.Add("Especificaste la VLAN nativa del puerto trunk");
                return response;
            }
            if (args[0] == "switchport_trunk_allowed_vlan_10_20" && c.nombre == "Switch")
            {
                
                tr3 = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " 451safttttttttseag";
                GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#";


                response.Add("Especificaste las VLAN que se permiten en el puerto trunk");
                return response;
            }

            // if (args[0] == "no_shutdown")
            //  {
            //      GameObject.Find("DirectoryText1").GetComponent<Text>().name = " aeqqqhddd";
            //      GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";
            //      response.Add("La interfaz se ha activado");
            //      return response;

            //  }
            return response;
        }


        else
        {

            Debug.Log("Menu opened");
            response.Add("Algo anda mal, revisa que hayas hecho correcto");
            if (cont == 1)
            {
                response.Remove("Algo anda mal, revisa que hayas hecho correcto");
            }
            cont = 1;
            return response;

        }
    }
}
