using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleControl : MonoBehaviour
{
    public float speed = 10f;        // Velocidad del vehículo
    public float turnSpeed = 50f;    // Velocidad de giro
    public float reverseSpeed = 5f;  // Velocidad en reversa

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        // Movimiento hacia adelante y en reversa
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (move < 0) // Si se mueve en reversa
        {
            move = Input.GetAxis("Vertical") * reverseSpeed * Time.deltaTime;
        }

        // Giro
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        // Aplicar movimiento
        rb.MovePosition(transform.position + transform.forward * move);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, turn, 0));
    }
}
