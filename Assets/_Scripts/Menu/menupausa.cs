using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour
{
    public GameObject ObejetoMenuPausa;
    public bool Pausa = false;
    menudispositivo md;
    public bool sobremenu = false;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Pausa == false)
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
    public void Resumir()
    {
        ObejetoMenuPausa.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;

    }


    public void RegresarMenu(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("aqui se cierra el juego");
    }
}

