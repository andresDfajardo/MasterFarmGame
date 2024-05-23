using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "Personaje")]
public class SeleccionPersonaje : ScriptableObject
{
    public GameObject personajeJugable;

    public Sprite imagen;

    public string nombre;
}
