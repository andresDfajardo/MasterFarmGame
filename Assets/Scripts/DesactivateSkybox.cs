using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    public Light directionalLight; // Referencia a la Directional Light
    public Vector3 activateRotation; // Rotación en la que se activa el Skybox
    public Vector3 deactivateRotation; // Rotación en la que se desactiva el Skybox
    private Skybox skyboxComponent; // Componente Skybox de la Main Camera

    private float rotationThreshold = 0.1f; // Margen de error para la comparación de rotaciones

    private void Start()
    {
        // Obtener el componente Skybox de la cámara principal
        skyboxComponent = GetComponent<Skybox>();

        if (skyboxComponent == null)
        {
            Debug.LogError("No se encontró el componente Skybox en la Main Camera.");
        }
        if (directionalLight != null && skyboxComponent != null)
        {
            // Comprueba la rotación de la Directional Light con un margen de error
            if (ApproximatelyEqual(directionalLight.transform.eulerAngles, activateRotation, rotationThreshold) && !skyboxComponent.enabled)
            {
                skyboxComponent.enabled = true;
            }
            else if (ApproximatelyEqual(directionalLight.transform.eulerAngles, deactivateRotation, rotationThreshold) && skyboxComponent.enabled)
            {
                skyboxComponent.enabled = false;
            }
        }
    }

    void Update()
    {
        
    }

    // Función para comparar vectores con un margen de error
    bool ApproximatelyEqual(Vector3 a, Vector3 b, float threshold)
    {
        return Vector3.Distance(a, b) < threshold;
    }
}
