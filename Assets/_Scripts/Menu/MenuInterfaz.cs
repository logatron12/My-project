using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInterfaz : MonoBehaviour
{
    public GameObject ObejetoMenuPausa;
    public bool Pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

        
    }

    public void pausar()
    {
        ObejetoMenuPausa.SetActive(false);
    }

    public void Resumir()
    {
        ObejetoMenuPausa.SetActive(false);
        Pausa = false;

        
        

    }

    public void Activar()
    {
        ObejetoMenuPausa.SetActive(true);
        Pausa = false;
    }

    public void Reutilizar()
    {

        ObejetoMenuPausa.SetActive(true);
        Pausa = false;

    }
}
