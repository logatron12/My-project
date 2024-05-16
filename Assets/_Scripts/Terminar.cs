using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminar : MonoBehaviour
{
    public GameObject ObejetoMenuPausa;
    // Start is called before the first frame update

    public void Final()
    {
        ObejetoMenuPausa.SetActive(true);

        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
    }
    public void Empezarnivel(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("aqui se cierra el juego");
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
