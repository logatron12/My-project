using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cables : MonoBehaviour
{

    public bool playerLan;
    public bool playerPower;
    public bool playerConsol;
    public bool playerSerial;
    public bool playerLan2;
    public bool playerPower2;
    public bool playerConsol2;
    public bool playerSerial2;
    public string nombre;
    public Switch s;


    public void Awake()
    {
        //s = GameObject.FindWithTag("Router").GetComponent<Switch>();
    }

    public void Tageo()
    {
        nombre = s.Nombre;
        
    }
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
