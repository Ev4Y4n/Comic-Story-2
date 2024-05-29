using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PalabrasCorto : MonoBehaviour
{
    public static PalabrasCorto THIS; //Variable estatica que permite acceder al script desde otros 
    private string input; // Variable privada que almacena la entrada de texto

    public GameObject paginaA; //variable que contiene la página A 
    public GameObject paginaH;
    public GameObject paginaN;
    public GameObject paginaJ;

    public GameObject letra1;
    public GameObject letra2;
    public GameObject letra3;
    public GameObject alerta;

    public GameObject levelCaminoCorto;


    public Button botonAcierto_1;
    public Button botonAcierto_2;
    public Button botonAcierto_3;
    
    public Button botonIncorrecto_1;
    public Button botonIncorrecto_2;
    public Button botonIncorrecto_3;
    public Button botonIncorrecto_4;
    public Button botonIncorrecto_5;
    public Button botonIncorrecto_6;
    
    public GameObject foto_1;
    public GameObject foto_2;
    public GameObject foto_3;

    public Sprite imagenCorrecto;
    public Sprite imagenIncorrecto;

    private bool j;
    private bool starta;
    private bool starth;
    private bool startn;

    public GameObject flechaDerecha;
    public GameObject LevelInfo;
    public GameObject Info;
    public GameObject Salir;

    public bool textoAterminado = false; //Variable para saber si se ha terminado de escribir el texto

    public int caminoTerminado;

    public bool pase1=false;
    public bool pase2=false;
    public bool pase3=false;

    public GameObject verde_a;
    public GameObject verde_h;
    public GameObject verde_n;

    public GameObject mapaP1;
    public bool mapaP1Activada; //Variable para comprobar si el mapa del piso 1 esta activado o no
    
    public GameObject mapaP2;
    public bool mapaP2Activada;


    public GameObject A; //Variable que contiene el indicador de la pregunta A
    public GameObject H;
    public GameObject N;

    private void Awake()
    {
        THIS = this;
    }


    public void Update()
    {
        if (LevelInfo.activeSelf == true && starta == true)
        {
            alerta.SetActive(false); // Desactiva la alerta si LevelInfo y startA están activados        
        }
        
        
        if (LevelInfo.activeSelf == true && starth == true)
        {
            alerta.SetActive(false);
        }

        if (LevelInfo.activeSelf == true && startn == true)
        {
            alerta.SetActive(false);           
        }

        if (pase1 == true && pase2 == true && pase3 == true && j == false) 
        {            
            paginaJ.SetActive(true); // Activa la página J si todos los pases son verdaderos y j es falso                
            flechaDerecha.SetActive(false);// Desactiva la flecha derecha
            alerta.SetActive(false); // Desactiva la alerta
            Info.SetActive(false);// Desactiva la información
            Salir.SetActive(false);// Desactiva el botón de salir
            j = true; // Establece j en verdadero
            verde_n.SetActive(false); // Desactiva el indicador verde para N
        }
    }


    public void RespuestaCorecta_1() //Método que controla cuando se da al botón de la respuesta correcta
    {
        letra1.SetActive(true); // Activa la letra 1
        alerta.SetActive(true); // Activa la alerta
        starta = true; // Establece starta en verdadero
        foto_1.SetActive(true); // Activa la foto 1
        pase1 = true; // Establece pase1 en verdadero
        flechaDerecha.SetActive(true); // Activa la flecha derecha
        verde_a.SetActive(false); // Desactiva el indicador verde para A
        verde_h.SetActive(true); // Activa el indicador verde para H
        A.SetActive(false); // Desactiva el objeto A
        H.SetActive(true); // Activa el objeto H
        botonAcierto_1.image.sprite = imagenCorrecto;

    }

    public void RespuestaCorecta_2()
    {
        letra2.SetActive(true);
        alerta.SetActive(true);
        starth = true;
        foto_2.SetActive(true);
        pase2 = true;
        flechaDerecha.SetActive(true);
        verde_h.SetActive(false);
        verde_n.SetActive(true);
        H.SetActive(false);
        N.SetActive(true);
        botonAcierto_2.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_3()
    {
        letra3.SetActive(true);
        alerta.SetActive(true);
        startn = true;
        foto_3.SetActive(true);
        pase3 = true;       
        verde_n.SetActive(false);
        N.SetActive(false);
        botonAcierto_3.image.sprite = imagenCorrecto;
    }
    public void RespuestaIncorecta_1()
    {

        botonIncorrecto_1.image.sprite = imagenIncorrecto;
        
    }
    public void RespuestaIncorecta_2()
    {
        botonIncorrecto_2.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_3()
    {
        botonIncorrecto_3.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_4()
    {
        botonIncorrecto_4.image.sprite = imagenIncorrecto;
    }

    public void RespuestaIncorecta_5()
    {
        botonIncorrecto_5.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_6()
    {
        botonIncorrecto_6.image.sprite = imagenIncorrecto;
    }

    public void OpenPanel(GameObject panel) //Método que guarda que has pasado el camino corto
    {
        
        Debug.Log("Este guarda que has pasado nivel 1");
        levelCaminoCorto.SetActive(false);
        Info.SetActive(true);
        mapaP1.SetActive(false);
        mapaP2.SetActive(false);
        
    }

    public void NivelTerminado() //Método que almacena que has terminado el nivel
    {
        caminoTerminado = 1;
        mapaP1.SetActive(false);//Se desactiva el mapa de la planta 1
        mapaP2.SetActive(false);//Se desactiva el mapa de la planta 2
    }

    public void ReadStringInput(string s)
    {
        input = s; // Asigna la entrada de texto a la variable input
        Debug.Log(input);// Muestra la entrada de texto en la consola
    }

    public void AbrirMapaP1() //Método que se encarga de abrir el mapa de la primera planta cuando le das al minimapa
    {
        if (mapaP1Activada)//Si presionas el botón una vez y el mapa ya esta activado, entonces se desactivará
        {
            mapaP1.SetActive(false);
            mapaP1Activada = false;
        }
        else
        {
            mapaP1.SetActive(true);
            mapaP1Activada = true;
        }
        
    }

    public void AbrirMapaP2()//Método que se encarga de abrir el mapa de la segunda planta cuando le das al minimapa
    {
        if (mapaP2Activada) //Si presionas el botón una vez y el mapa ya esta activado, entonces se desactivará
        {
            mapaP2.SetActive(false);
            mapaP2Activada = false;
        }
        else
        {
            mapaP2.SetActive(true);
            mapaP2Activada = true;
        }

    }
}
