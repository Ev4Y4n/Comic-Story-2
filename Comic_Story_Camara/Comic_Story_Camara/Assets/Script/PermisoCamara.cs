using UnityEngine;
using UnityEngine.Android;
using UnityEngine.XR.ARFoundation;

public class PermisoCamara : MonoBehaviour
{
    private ARSession arSession;

    void Start()
    {
        // Obt�n la referencia a la sesi�n de AR
        arSession = FindObjectOfType<ARSession>();

        // Comprueba y solicita permiso de c�mara
        CheckAndRequestPermission();
    }

    void CheckAndRequestPermission()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // Solicitar permiso de la c�mara
            Permission.RequestUserPermission(Permission.Camera);
        }
        else
        {
            // Permiso concedido, inicializar la AR
            InitializeAR();
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            // Verificar el permiso nuevamente cuando la aplicaci�n recupere el foco
            if (Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                // Permiso concedido, inicializar la AR
                InitializeAR();
            }
        }
    }

    void InitializeAR()
    {
        if (arSession != null && !arSession.enabled)
        {
            // Activa la sesi�n de AR
            arSession.enabled = true;
            Debug.Log("AR Session iniciada");
        }
    }

    void Update()
    {
        // Si se concede el permiso despu�s de solicitarlo, inicializar la AR
        if (Permission.HasUserAuthorizedPermission(Permission.Camera) && !arSession.enabled)
        {
            InitializeAR();
        }
    }
}