using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astronautMovement : MonoBehaviour
{

    public float speed = 12f;
    public float turnSpeed = 100f;
    Transform astronaut;
    public CharacterController controller;   
    void Awake(){
        astronaut = transform;
    }
    void Start()
    {
        
    }

    void Update()
    {
        move();
        rotate();
        
        
    }
    void move()
    {
        float poruszanie = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //astronaut.position += astronaut.forward * poruszanie;
        Vector3 move = astronaut.right * poruszanie;
        controller.Move(move);
    }

    void rotate()
    {
        float obrotY = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        float vrtY = Input.GetAxis("VertY") * Time.deltaTime * turnSpeed;
        float sroll = Input.GetAxis("Sideroll") * Time.deltaTime * turnSpeed;
        astronaut.Rotate(-sroll, obrotY, vrtY);
    }
}
