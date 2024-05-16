using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifPrefab : MonoBehaviour
{
    public GameObject prefabReferenciado;
    Text nombre;


    public void cambionombre()
    {
        nombre.text = "";
        GameObject.Find("DirectoryText").GetComponentInChildren<Text>().text = nombre.text;
        
    }
}
