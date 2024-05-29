using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class Geolocalizacion : MonoBehaviour
{
    public static Geolocalizacion Instance { set; get; } //Se le asiggna una popiedad estática para que se pueda acceder al script desde otros

    //Variables que contienen las coordenadas de la posición del jugador 
    public float latitude;
    public float longitude;

    //Variables que contienen las coordenadas del museo 
    private float latitudMuseo = 40.423319f; 
    private float longitudMuseo = -3.6888072f;

    public float umbralDistancia = 0.1f; //Variable para saber si el jugador esta cerca del museo o no

    public Image iconoJugador; //Icono del jugador que se activará si está dentro del museo

    private bool permissionRequested = false; //Variable para saber si se ha concedido permiso para acceder a la ubicación del movil

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject); //Metodo para que no se destruya el script entre escenas
        StartCoroutine(EmpezarGPS()); //Da comienzo a la corrutina que da a comenzar el GPS
        iconoJugador.gameObject.SetActive(false); //Al empezar, el icono del jugador esta desactivado ya que se tiene que activar una vez que el jugador haya entrado al museo
    }

    //Corrutina que da a empezar al GPS
    private IEnumerator EmpezarGPS()
    {
        if (!permissionRequested) //Se comprueba si se ha solicitado permiso para acceder a la ubicación o no
        {
            Debug.Log("Permiso");
            permissionRequested = true; //Si el jugador le da permiso, se activa la ubicacion 
            yield return RequestLocationPermission();
        }
        if (!Input.location.isEnabledByUser) //Se comprueba si el jugador ha dado permiso para que se pueda acceder a su ubicación
        {
            Debug.Log("Usuario no ha activado la ubicación"); //Significa que el jugador no ha dado permiso 
            yield break;
        }
        //Si ve que no se ha accedido a la ubicación, vuelve a probar y si en 20 segundos no tiene acceso, le da error
        Input.location.Start();
        int maxWait = 20;

        while(Input.location.status==LocationServiceStatus.Initializing&& maxWait>0)//Comprueba de que el tiempo de espera no se ha terminado
        {
            yield return new WaitForSeconds(1);
            maxWait--;//Va bajando el tiempo de espera
        }

        if (maxWait <= 0) //Si se ha agotado el tiempo de espera
        {
            Debug.Log("Se acabó el tiempo");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed) //En caso de que no se encuentre la ubicación 
        {
            Debug.Log("No se ha podido encontrar la ubicación");
            yield break;
        }

        // Obtiene las coordenadas de la última ubicación conocida del jugador 
        float latitude = Input.location.lastData.latitude;
        float longitude = Input.location.lastData.longitude;

        float distancia = CalcularDistancia(latitude, longitude, latitudMuseo, longitudMuseo); //Te calcula la distacia que estas del museo

        if (distancia < umbralDistancia) // Si la distancia es menor que el umbral
        {
            Debug.Log("Has llegado al museo"); //Si detecta que estas dentro, te hace el método de DentroMuseo
            DentroMuseo();
        }
    }

    //Corrutina que hace que se active la notificación del permiso de poder acceder a la ubicación del movil
    private IEnumerator RequestLocationPermission()
    {
        while (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))// Mientras no se haya concedido el permiso
        {
            Permission.RequestUserPermission(Permission.FineLocation); //Solicita el permiso al jugador
            yield return new WaitForSeconds(1);
        }
    }

    private float CalcularDistancia(float latitud1, float longitud1, float latitud2, float longitud2) // Método para calcular la distancia entre dos puntos geográficos
    {
        // Convierte las coordenadas de grados a radianes
        float latitudRadianes1 = latitud1 * Mathf.Deg2Rad;
        float longitudRadianes1 = longitud1 * Mathf.Deg2Rad;
        float latitudRadianes2 = latitud2 * Mathf.Deg2Rad;
        float longitudRadianes2 = longitud2 * Mathf.Deg2Rad;

        // Calcula la distancia utilizando la fórmula del coseno esférico
        float distancia = Mathf.Acos(Mathf.Sin(latitudRadianes1) * Mathf.Sin(latitudRadianes2) +
                                      Mathf.Cos(latitudRadianes1) * Mathf.Cos(latitudRadianes2) *
                                      Mathf.Cos(longitudRadianes2 - longitudRadianes1)) * Mathf.Rad2Deg;

        distancia *= 111.32f; // Convierte la distancia de grados a kilómetros

        return distancia;
    }

    // Método que se llama cuando el jugador está dentro del museo
    public void DentroMuseo()
    {
        // Obtiene las coordenadas de la última ubicación conocida
        float latitude = Input.location.lastData.latitude;
        float longitude = Input.location.lastData.longitude;

        // Calcula la distancia entre la posición actual y el museo
        float distancia = CalcularDistancia(latitude, longitude, latitudMuseo, longitudMuseo);

        if (distancia < umbralDistancia) // Si la distancia es menor que el umbral
        {
            iconoJugador.gameObject.SetActive(true);// Activa el icono del jugador
        }
    }
}
