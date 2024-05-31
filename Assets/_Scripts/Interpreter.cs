using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public bool rip4;
    public bool rr;
    public bool eigrp1;
    public bool eigrp2;
    public bool eigrp3;
    public bool eigrp4;
    public bool eg;
    public bool tr1;
    public bool tr2;
    public bool tr3;
    public bool tr4;
    public bool tr5;
    public bool tr6;
    public int cont = 0;
    public bool cont1 = true;
    public bool cont2 = true;
    public int cont3 = 0;
    public int cont4 = 0;
    public int cont5 = 0;
    public int cont6 = 0;
    public int cont7 = 0;

    List<string> response = new List<string>();

    private void Awake()
    {
        c = GameObject.Find("Player").GetComponent<Cables>();
        if (SceneManager.GetActiveScene().name == "Ejercicio 4")
        {
            s = GameObject.FindWithTag("Switch").GetComponent<Switch>();
        }else 
        if ((SceneManager.GetActiveScene().name == "Ejercicio 1") || (SceneManager.GetActiveScene().name == "Ejercicio 2") || (SceneManager.GetActiveScene().name == "Ejercicio 3"))
        {
            s = GameObject.FindWithTag("Router").GetComponent<Switch>();
        }
            
        
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

            if (args[0] == "config_t" || args[0] == "configure_terminal")
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

            if (args[0] == "Interface_fa0/0" || args[0] == "Interface_fa0/1" || args[0] == "Interface_fa0/2" || args[0] == "Interface_fa0/3" || args[0] == "Interface_fa0/4" || args[0] == "interface_fa0/1" || args[0] == "interface_fa0/2" || args[0] == "interface_fa0/3" || args[0] == "interface_fa0/4" || args[0] == "interface_fa0/0")
            {
                /*
                
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " asdaewrwdd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";

                }
                 */
                response.Add("Has accedido exitosamente a la configuracion de la interface FastEthernet");
                
                return response;
                 
            }

            if (args[0] == "ip_add_192.168.20.1_255.255.255.0" || args[0] == "ip_add_200.200.200.1_255.255.255.0" || args[0] == "ip_add_192.168.30.1_255.255.255.0" || args[0] == "ip_add_192.168.2.1_255.255.255.0" || args[0] == "ip_add_192.168.1.1_255.255.255.0" || args[0] == "ip_add_172.16.30.1_255.255.0.0" || args[0] == "ip_add_172.16.0.1_255.255.0.0")
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
                /*
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfhhhddd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                */
               response.Add("La interfaz se ha activado");

                return response;
            }
            if (args[0] == "exit")
            {
                /*
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfddrd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                */
                response.Add("Saliste de la configuracion de la configuracion de la interface FastEthernet");

                return response;
            }
            if (args[0] == "interface_se0/0/0" || args[0] == "interface_se0/0/1")
            {
                /*
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " qqfiidd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-if)#  ";

                }
                */
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
                /*
                GameObject.Find("DirectoryText1").GetComponent<Text>().name = " ahfggddd";
                if (c.nombre == "Switch")
                {

                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#  ";

                }
                else if (c.nombre == "Router")
                {
                    GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";

                };
                */
                response.Add("Has asignado exitosamente la ip a la interface Serial");

                return response;
            }
            if (args[0] == "router_rip" && c.nombre == "Router")
            {
                
                rr = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsaf8seag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";


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

                    if (cont1 == true) {
                        rip3 = true;
                        cont1 = false;
                    }
                    else if (cont1 == false) {
                        rip4 = true;
                    }
                    
                }

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsa78asdafseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Red configurada");

                return response;
            }
            if (args[0] == "version_2" && rr == true)
            {
                
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdad451safseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Estableciste la version del router RIP");

                return response;
            }
            if (args[0] == "no_auto-summary")
            {
                

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsafseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Se deshabilito la sumarización automática");

                return response;
            }
            if (args[0] == "router_eigrp_10" && c.nombre == "Router")
            {
                
                eg = true;
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsaf8seag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config)#  ";


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
                    
                    if (cont1 == true)
                    {
                        eigrp3 = true;
                        cont1 = false;
                    }
                    else if (cont1 == false)
                    {
                        eigrp4 = true;
                    }
                }

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdadsa78asdafseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Router(config-router)#";


                response.Add("Red configurada");

                return response;
            }
            if (args[0] == "switchport_mode_trunk" ) 
            {
                if (cont3 == 2)
                {

                    tr1 = true;
                }

                if (cont3 == 1)
                {
                    cont3 = 2;

                }
                if (cont3 == 0)
                {

                    cont3 = 1;
                }
                

                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " dasdasasad451safseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config)#";


                response.Add("Configuraste el puerto en modo trunk");

                return response;
            }
            if (args[0] == "switchport_trunk_native_vlan_99" )
            {
                if (cont4 == 2)
                {

                    tr2 = true;
                }

                if (cont4 == 1)
                {
                    cont4 = 2;

                }
                if (cont4 == 0)
                {

                    cont4 = 1;
                }
                
                
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " 451safseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#";


                response.Add("Especificaste la VLAN nativa del puerto trunk");
                return response;
            }
            if (args[0] == "switchport_trunk_allowed_vlan_10,20" )
            {
                if (cont5 == 7)
                {
                    tr4 = true;
                    cont5 = 8;
                }
                if (cont5 == 6)
                {
                    tr3 = true;
                    cont5 = 7;
                }
                if (cont5 == 5)
                {
                    cont5 = 6;
                }
                if (cont5 == 4)
                {                  
                    cont5 = 5;
                }

                if (cont5 == 3)
                {
                    cont5 = 4;
                }

                if (cont5 == 2)
                {
                    
                    cont5 = 3;
                }

                if (cont5 == 1)
                {
                    cont5 = 2;
                }

                if (cont5 == 0)
                {
                    cont5 = 1;
                }

               
                //GameObject.Find("DirectoryText").GetComponentInChildren<Text>().name = " asdd";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().name = " 451safttttttttseag";
                //GameObject.Find("DirectoryText1").GetComponent<Text>().text = "Switch(config-if)#";


                response.Add("Especificaste las VLAN que se permiten en el puerto trunk");
                return response;
            }
            if (args[0] == "vlan_10")
            {
               
                response.Add("Accediste a la configuracion de la vlan 10");

                return response;
            }
            if (args[0] == "vlan_20")
            {

                response.Add("Accediste a la configuracion de la vlan 20");

                return response;
            }
            if (args[0] == "name_VLAN10")
            {

                response.Add("nombraste a la vlan 10 como VLAN10");

                return response;
            }
            if (args[0] == "name_VLAN20")
            {

                response.Add("nombraste a la vlan 20 como VLAN20");

                return response;
            }
            if (args[0] == "switchport_mode_access")
            {
                

                response.Add("Configuraste el puerto en modo acceso");

                return response;
            }
            if (args[0] == "switchport_access_vlan_10")
            {
                if (cont6 == 3)
                {
                    
                    cont6 = 4;
                }

                if (cont6 == 2)
                {
                    tr5 = true;
                    cont6 = 3;
                }

                if (cont6 == 1)
                {
                    cont6 = 2;
                }

                if (cont6 == 0)
                {
                    cont6 = 1;
                }

                response.Add("Configuraste el puerto para el acceso de la vlan 10");

                return response;
            }
            if (args[0] == "switchport_access_vlan_20")
            {
                if (cont7 == 2)
                {
                    
                    cont7 = 3;
                }

                if (cont7 == 1)
                {
                    tr6 = true;
                    cont7 = 2;
                }

                if (cont7 == 0)
                {
                    cont7 = 1;
                }


                response.Add("Configuraste el puerto para el acceso de la vlan 20");

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
