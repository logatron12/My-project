using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menudispositivo : MonoBehaviour
{
    public GameObject ObejetoMenuPausa;
    public bool Pausa = false;
    public bool P = false;
    menupausa mp;



    public void GuardasNombre(string Dispositivo)
    {
        string nombreDispositivo = gameObject.name;

        // Llamamos al método `nuevo()` del script `Switch` y le pasamos el nombre del dispositivo como argumento.
        //Switch.nuevo(nombreDispositivo);
    }

    // Start is called before the first frame update
    void Start()
    {
       

    }

    private void Awake()
    {
        mp = GameObject.Find("CanvasPausa").GetComponent<menupausa>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && mp.Pausa == true)
        {
            Resumir2();
        }

    }

    public void Abrimenu(bool iniciar)
    {
        if(iniciar == true){


            if (Pausa == false)
            {

                ObejetoMenuPausa.SetActive(true);
                

                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
                
            }
        }
    }
    public void Reutilizar()
    {
        
        ObejetoMenuPausa.SetActive(false);
        Pausa = false;
        
    }


    public void Encendido()
    {
        string nombreDispositivo = gameObject.name;
        GameObject.Find(nombreDispositivo).GetComponent<menudispositivo>().Pausa = false;
    }

    public void Resumir()
    {
        string nombreDispositivo = gameObject.name;
        GameObject.Find(nombreDispositivo).GetComponent<menudispositivo>().Pausa = false;
        ObejetoMenuPausa.SetActive(false);
        gameObject.GetComponent<menudispositivo>().Reutilizar();
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        Pausa = false;
        

    }
    public void Resumir2()
    {
        string nombreDispositivo = gameObject.name;
        GameObject.Find(nombreDispositivo).GetComponent<menudispositivo>().Pausa = false;
        ObejetoMenuPausa.SetActive(false);
        gameObject.GetComponent<menudispositivo>().Reutilizar();
        

    }

    public void On()
    {
        string nombreDispositivo = gameObject.name;
        GameObject.Find(nombreDispositivo).GetComponent<Switch>().Encendido = true;
    }
    public void Off()
    {
        string nombreDispositivo = gameObject.name;
        GameObject.Find(nombreDispositivo).GetComponent<Switch>().Encendido = false;
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("aqui se cierra el juego");
    }
}

