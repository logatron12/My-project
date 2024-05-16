using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    private new Transform camera;


    public float rayDistance;
    
    void Start()
    {
        
        camera = transform.Find("Camera");

    }

    
    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);

       

    }

   
}
