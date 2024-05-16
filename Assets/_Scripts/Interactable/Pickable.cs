using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickable : Interactable
{
    public override void Interact()
    {

        Destroy(gameObject);
    }
}
