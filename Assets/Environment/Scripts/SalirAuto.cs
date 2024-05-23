using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirAuto : MonoBehaviour
{
    public EntrarAuto entrarAuto;
    public GameObject camaraVehiculo;
    public GameObject jugador;
    public GameObject object1;
    public VehicleControl vehicleControl;

    // Start is called before the first frame update
    void Start()
    {
        jugador = entrarAuto.jugador;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            salirVehiculo();
        }
    }
    public void salirVehiculo()
    {
        jugador.SetActive(true);

        jugador.transform.position = object1.transform.position;

        camaraVehiculo.SetActive(false);
        vehicleControl.enabled = false;
        entrarAuto.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
