using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAnimation : MonoBehaviour
{

    public GameObject botonAnimacion_1; //Varialble que adjuntas para el boton
    public GameObject botonAnimacion_2;
    public GameObject botonAnimacion_3;
    public GameObject botonAnimacion_4;

    public void Boton2()
    {
        botonAnimacion_1.SetActive(false); //Desactiva el botonAnimacion_1
        botonAnimacion_2.SetActive(true); //Activa el botonAnimacion_2
    }
    public void Boton3()
    {
        botonAnimacion_2.SetActive(false);
        botonAnimacion_3.SetActive(true);
    }
    public void Boton4()
    {
        botonAnimacion_3.SetActive(false);
        botonAnimacion_4.SetActive(true);
    }
    public void Boton5()
    {
        botonAnimacion_4.SetActive(false);
        
    }
    public void BotonFinal()
    {
        SceneManager.LoadScene("Juego", LoadSceneMode.Single); //Al dar al boton que tenga este Metodo la escena cambia a la llamada Juego
    }


}
