using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFX; //Variable que contiene el modificador del volumen
    [Header("Panels")]
    public GameObject idiomaPanel; //Variable que almacena el panel donde aparecen las opciones de idioma
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public string Url; // Variable p�blica que almacena la URL a la que se quiere acceder desde el men�
    public void OpenPanel(GameObject panel) //Te activa el panel 
    {
        mainPanel.SetActive(false); //Desactiva el panel principal
        optionsPanel.SetActive(false); //Desactiva el panel de las opciones

        panel.SetActive(true); //Se activa el panel que esta como par�metro
    }

    public void PlayLevel(string levelName) // M�todo p�blico para cargar una escena espec�fica
    {
        SceneManager.LoadScene(levelName); // Carga la escena con el nombre especificado
    }

    public void ExitGame() //M�todo que te hace salir del juego
    {
        Application.Quit(); //Cierra la aplicaci�n 
    }
    public void Open()// M�todo p�blico para abrir una URL
    {
        Application.OpenURL(Url); // Abre la URL almacenada en la variable Url
    }

    public void IdiomaPanel(GameObject panel) //M�todo que te activa el panel de idiomas
    {
        idiomaPanel.SetActive(false);// Desactiva el panel de idioma
        mainPanel.SetActive(false);// Desactiva el panel principal

        panel.SetActive(true);//Se activa el panel que esta como par�metro
    }
}