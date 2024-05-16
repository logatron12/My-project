using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            power = true;
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
            red = true;
            
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
            consola = true;
            
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
            serial = true;
            
        }
    }

    public void R1()
    {
        
        GameObject.Find("R1").GetComponent<Text>().color = Color.green;
        GameObject.Find("R1").GetComponent<Text>().text = "R1";
        power = true;

    }
    public void S1()
    {

        GameObject.Find("S1").GetComponent<Text>().color = Color.green;
        GameObject.Find("S1").GetComponent<Text>().text = "S1";
        consola = true;

    }
    public void R2()
    {

        GameObject.Find("R2").GetComponent<Text>().color = Color.green;
        GameObject.Find("R2").GetComponent<Text>().text = "R2";
        red = true;

    }
    public void S2()
    {
        GameObject.Find("S2").GetComponent<Text>().color = Color.green;
        GameObject.Find("S2").GetComponent<Text>().text = "S2";
        serial = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if ((GetComponent<cajaCables>().red = true) || (GetComponent<cajaCables>().power = true) || (GetComponent<cajaCables>().consola = true) || (GetComponent<cajaCables>().serial = true))
        {
            if (cont == 1)
            {
                R1();
                cont = 5;
            }
            if (cont == 2)
            {
                S1();
                cont = 5;
            }
            if (cont == 3)
            {
                S2();
                cont = 5;
            }
            if (cont == 4)
            {
                R2();
                cont = 5;
            }

        }
    }
}
