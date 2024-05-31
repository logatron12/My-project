using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cajaCables : MonoBehaviour
{
    public bool red = false;
    public bool power = false;
    public bool consola = false;
    public bool serial = false;
    public Text texto;
    public TakeObject to;
    public Cables cable;
    public Switch s;
    private int cont = 0;
    public int cont1 = 0;

    private bool r1Executed = false;
    private bool s1Executed = false;
    private bool s2Executed = false;
    private bool r2Executed = false;
    private bool s11Executed = false;
    private bool s12Executed = false;
    private bool s13Executed = false;
    private bool s14Executed = false;


    public void recogerpower(float fase)
    {
        if (fase == 0)
        {
            texto.color = Color.red;
            texto.text = "Off / Off";
        }else if (fase == 1)
        {
            texto.color = Color.blue;
            texto.text = "On / Off";
        }
        else if (fase == 2)
        {
            texto.color = Color.blue;
            texto.text = "Off / On";
        }
        else if(fase == 3){
            texto.color = Color.green;
            texto.text = "On / On";
            GameObject.Find("hand").GetComponent<TakeObject>().powerlock = false;
            
            
            cont = cont + 1;
        }
        
    }
    public void recogerred(float fase)
    {
        if (fase == 0)
        {
            texto.color = Color.red;
            texto.text = "Off / Off";
        }
        else if (fase == 1)
        {
            texto.color = Color.blue;
            texto.text = "On / Off";
        }
        else if (fase == 2)
        {
            texto.color = Color.blue;
            texto.text = "Off / On";
        }
        else if (fase == 3)
        {
            texto.color = Color.green;
            texto.text = "On / On";
            GameObject.Find("hand").GetComponent<TakeObject>().redlock = false;
            


        }
    }
    public void recogerconsola(float fase)
    {
        if (fase == 0)
        {
            texto.color = Color.red;
            texto.text = "Off / Off";
        }
        else if (fase == 1)
        {
            texto.color = Color.blue;
            texto.text = "On / Off";
        }
        else if (fase == 2)
        {
            texto.color = Color.blue;
            texto.text = "Off / On";
        }
        else if (fase == 3)
        {
            texto.color = Color.green;
            texto.text = "On / On";
            GameObject.Find("hand").GetComponent<TakeObject>().consollock = false;
            
            
        }
    }
    public void recogerserial(float fase)
    {
        if (fase == 0)
        {
            texto.color = Color.red;
            texto.text = "Off / Off";
        }
        else if (fase == 1)
        {
            texto.color = Color.blue;
            texto.text = "On / Off";
        }
        else if (fase == 2)
        {
            texto.color = Color.blue;
            texto.text = "Off / On";
        }
        else if (fase == 3)
        {
            texto.color = Color.green;
            texto.text = "On / On";
            GameObject.Find("hand").GetComponent<TakeObject>().seriallock = false;
           
        }
    }

    public void R1()
    {
        
        GameObject.Find("R1").GetComponent<Text>().color = Color.green;
        GameObject.Find("R1").GetComponent<Text>().text = "R1";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().red = true;
        red = true;
        

    }
    public void S1()
    {

        GameObject.Find("S1").GetComponent<Text>().color = Color.green;
        GameObject.Find("S1").GetComponent<Text>().text = "S1";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().power = true;
        power = true;
        

    }
    public void R2()
    {

        GameObject.Find("R2").GetComponent<Text>().color = Color.green;
        GameObject.Find("R2").GetComponent<Text>().text = "R2";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().consola = true;
        consola = true;

    }
    public void S2()
    {
        GameObject.Find("S2").GetComponent<Text>().color = Color.green;
        GameObject.Find("S2").GetComponent<Text>().text = "S2";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().serial = true;
        serial = true;

    }

    public void S11()
    {

        GameObject.Find("R1").GetComponent<Text>().color = Color.green;
        GameObject.Find("R1").GetComponent<Text>().text = "S1";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().red = true;
        red = true;


    }

    public void S12()
    {

        GameObject.Find("S1").GetComponent<Text>().color = Color.green;
        GameObject.Find("S1").GetComponent<Text>().text = "S2";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().power = true;
        power = true;


    }

    public void S13()
    {

        GameObject.Find("S2").GetComponent<Text>().color = Color.green;
        GameObject.Find("S2").GetComponent<Text>().text = "S3";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().consola = true;
        consola = true;
        


    }
    public void S14()
    {

        GameObject.Find("R2").GetComponent<Text>().color = Color.green;
        GameObject.Find("R2").GetComponent<Text>().text = "S4";
        GameObject.Find("Interfaz").GetComponent<cajaCables>().serial = true;
        serial = true;


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void encendido(float cont1)
    {

        if ((SceneManager.GetActiveScene().name == "Ejercicio 1") || (SceneManager.GetActiveScene().name == "Ejercicio 2") || (SceneManager.GetActiveScene().name == "Ejercicio 3") && (GetComponent<cajaCables>().red = true) || (GetComponent<cajaCables>().power = true) || (GetComponent<cajaCables>().consola = true) || (GetComponent<cajaCables>().serial = true))
        {
            if (cont1 == 1 && !r1Executed)
            {
                R1();
                r1Executed = true;
            }
            if (cont1 == 2 && !s1Executed)
            {
                S1();
                s1Executed = true;
            }
            if (cont1 == 3 && !s2Executed)
            {
                S2();
                s2Executed = true;
            }
            if (cont1 == 4 && !r2Executed)
            {
                R2();
                r2Executed = true;
            }

        }
        if (SceneManager.GetActiveScene().name == "Ejercicio 4" )
        {
            if (cont1 == 1 && !s11Executed)
            {
                S11();
                s11Executed = true;
            }
            if (cont1 == 2 && !s12Executed)
            {
                S12();
                s12Executed = true;
            }
            if (cont1 == 3 && !s13Executed)
            {
                S13();
                s13Executed = true;
                r2Executed = true;
                r1Executed = true;
                s2Executed = true;
                s1Executed = true;
            }
            if (cont1 == 4 && !s14Executed)
            {
                S14();
                s14Executed = true;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
