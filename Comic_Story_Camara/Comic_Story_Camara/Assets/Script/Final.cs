using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public GameObject final; //Variable que contiene el panel del final

    public bool llave1 =false; //Variable para comprobar si la llave del camino corto está activado o no
    public bool llave2=false;
    public bool llave3=false;
    
    public void BotonCotoFinal() //Método que activa la llave del camino corto
    {
        llave1 = true;
    }
    public void BotonMedioFinal()
    {
        llave2 = true;
    }

    public void BotonLargoFinal()
    {
        llave3 = true;
    }

    void Update()
    {
        if(llave1==true & llave2==true & llave3 == true) //En caso de que hayas conseguido las tres llaves, te sale el panel del final porque has ganado
        {
            final.SetActive(true);
        }
    }

    public void CambiarEscenaCamara()
    {
        SceneManager.LoadSceneAsync(3); //Botón para cambiár a la escena de la cámara
    }
}
