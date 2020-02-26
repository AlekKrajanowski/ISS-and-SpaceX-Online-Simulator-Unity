using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform astronaut;
    
    void Start()
    {
        //to nizej blokuje myszke na w jednym miejscu i ja usuwa z widoku
       //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;             
        //astronaut.Rotate(Vector3.left * mouseX);
       // astronaut.Rotate(Vector3.down * mouseY);


    }
}
