using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{   
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;
 

    // start is called once per frame
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensY;
        
        yRotation += mouseX;
        xRotation -= mouseY;

    }   


}
