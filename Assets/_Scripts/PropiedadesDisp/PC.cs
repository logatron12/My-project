using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{

    public bool consolecable = false;
    public bool redcable = false;
    public void cableconsola()
    {
        consolecable = true;

    }
    public void cablered()
    {
        redcable = true;

    }
}
