using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabianMove : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 15f;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}


