using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float velocidad = 100f;
    float RotationX = 0f;

    public Transform player;    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MauseX = Input.GetAxis("Mouse X") * velocidad * Time.deltaTime;
        float MauseY = Input.GetAxis("Mouse Y") * velocidad * Time.deltaTime;

        RotationX -= MauseY;

        RotationX = Mathf.Clamp(RotationX, -90f, 90f);

        
        transform.localRotation = Quaternion.Euler(RotationX, 0f, 0f);
        player.Rotate(Vector3.up * MauseX);
    }
}
