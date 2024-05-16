using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asignarip : MonoBehaviour
{
    public GameObject ObejetoMenuPausa;
    public bool Pausa = false;
    public bool ip;
    public bool mask;
    MenuInterfaz mi;
    public void Abrimenu(bool iniciar)
    {
        if (iniciar == true)
        {

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

    public void guardar()
    {
        ip = true;
        mask = true;
    }

    public void Resumir()
    {

        ObejetoMenuPausa.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
        mi.Reutilizar();


    }
    public void Reutilizar()
    {

        ObejetoMenuPausa.SetActive(false);
        Pausa = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        mi = GameObject.Find("Interfaz").GetComponent<MenuInterfaz>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
