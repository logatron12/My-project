using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    //public Vector3 hingeOffset = new Vector3(0, 0, 1);
    public override void Interact()
    {
        base.Interact();

        //Vector3 hingePoint = transform.position + hingeOffset;

    
        transform.Rotate(Vector3.up * 90);

    }
}
