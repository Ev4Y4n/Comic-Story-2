using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PalabrasMedio : MonoBehaviour
{
    public static PalabrasMedio THIS;//Variable estatica que permite acceder al script desde otros 
    private string input; // Variable privada que almacena la entrada de texto

    public GameObject paginaB; //variable que contiene la página B 
    public GameObject paginaE;
    public GameObject paginaI;
    public GameObject paginaM;
    public GameObject paginaL;

    public GameObject letra1;
    public GameObject letra2;
    public GameObject letra3;
    public GameObject letra4;
    public GameObject alerta;

    public GameObject LevelCaminoMedio;

    public GameObject foto_1;
    public GameObject foto_2;
    public GameObject foto_3;
    public GameObject foto_4;

    public Button botonAcierto_1;
    public Button botonAcierto_2;
    public Button botonAcierto_3;
    public Button botonAcierto_4;

    public Button botonIncorrecto_1;
    public Button botonIncorrecto_2;
    public Button botonIncorrecto_3;
    public Button botonIncorrecto_4;
    public Button botonIncorrecto_5;
    public Button botonIncorrecto_6;
    public Button botonIncorrecto_7;
    public Button botonIncorrecto_8;
    public Button botonIncorrecto_9;
    public Button botonIncorrecto_10;
    public Button botonIncorrecto_11;
    public Button botonIncorrecto_12;

    public Sprite imagenCorrecto;
    public Sprite imagenIncorrecto;

    /*
    public GameObject botonIncorrectoB1;
    public GameObject botonIncorrectoB2;
    public GameObject botonIncorrectoB3;
    public GameObject botonIncorrectoE1;
    public GameObject botonIncorrectoE2;
    public GameObject botonIncorrectoE3;
    public GameObject botonIncorrectoI1;
    public GameObject botonIncorrectoI2;
    public GameObject botonIncorrectoI3;
    public GameObject botonIncorrectoM1;
    public GameObject botonIncorrectoM2;
    public GameObject botonIncorrectoM3;
    */

    [SerializeField]
    private bool e;
    private bool l;
    private bool startb;
    private bool starte;
    private bool starti;
    private bool startm;

    public GameObject flechaIzquierda;
    public GameObject flechaDerecha;
    public GameObject LevelInfo;
    public GameObject Info;
    public GameObject Salir;

    public bool textoAterminado = false; //Variable para saber si se ha terminado de escribir el texto

    public int caminoTerminado;

    public bool pase1 = false;
    public bool pase2 = false;
    public bool pase3 = false;
    public bool pase4 = false;

    public GameObject naranja_b; 
    public GameObject naranja_e;
    public GameObject naranja_i;
    public GameObject naranja_m;

    public GameObject mapaP1; 
    public bool mapaP1Activada; //Variable para comprobar si el mapa del piso 1 esta activado o no

    public GameObject mapaP2;
    public bool mapaP2Activada;

    public GameObject botonMinimapaB;
    public GameObject botonMinimapaE;

    public GameObject B;  //Variable que contiene el indicador de la pregunta B
    public GameObject E;
    public GameObject I;
    public GameObject M;

    private void Awake()
    {
        THIS = this;
    }
    public void Start()
    {
        B.SetActive(true);
    }
    public void Update()
    {
        if (LevelInfo.activeSelf == true && startb == true)
        {
            alerta.SetActive(false); // Desactiva la alerta si LevelInfo y startb están activados  

        }
        
        if (LevelInfo.activeSelf == true && starte == true)
        {
            alerta.SetActive(false);
            

        }

        if (LevelInfo.activeSelf == true && starti == true)
        {
            alerta.SetActive(false);
            
        }


        if (LevelInfo.activeSelf == true && startm == true)
        {
            alerta.SetActive(false);
            
        }

        if (pase1 == true && pase2 == true && pase3 == true && pase4 == true && l == false)
        {
            paginaL.SetActive(true); // Activa la página L si todos los pases son verdaderos y l es falso     
            flechaDerecha.SetActive(false);// Desactiva la flecha derecha
            alerta.SetActive(false);// Desactiva la alerta
            flechaIzquierda.SetActive(false); // Desactiva la flecha izquierda
            Info.SetActive(false); // Desactiva la información
            Salir.SetActive(false); // Desactiva el botón de salir
            l = true; // Establece l en verdadero


        }
    }

    public void RespuestaCorecta_1() //Método que controla cuando se da al botón de la respuesta correcta
    {
        letra1.SetActive(true); // Activa la letra 1
        alerta.SetActive(true); // Activa la alerta
        startb = true; // Establece startb en verdadero
        foto_1.SetActive(true); // Activa la foto 1
        pase1 = true; // Establece pase1 en verdadero
        flechaDerecha.SetActive(true); // Activa la flecha derecha
        naranja_b.SetActive(false); // Desactiva el indicador naranja para B
        naranja_e.SetActive(true); // Activar el indicador naranja para E
        B.SetActive(false); //Desactivar B
        botonMinimapaB.SetActive(false); //Desactivar botón del minimpapa B 
        botonMinimapaE.SetActive(true); //Desactivar botón del minimpapa E
        E.SetActive(true);//Activar E
        botonAcierto_1.image.sprite = imagenCorrecto;

    }

    public void RespuestaCorecta_2()
    {
        letra2.SetActive(true);
        alerta.SetActive(true);
        starte = true;
        foto_2.SetActive(true);
        pase2 = true;
        flechaDerecha.SetActive(true);
        naranja_e.SetActive(false);
        naranja_i.SetActive(true);
        E.SetActive(false);
        I.SetActive(true);
        botonAcierto_2.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_3()
    {
        letra3.SetActive(true);
        alerta.SetActive(true);
        starti = true;        
        foto_3.SetActive(true);
        pase3 = true;
        flechaDerecha.SetActive(true);
        naranja_i.SetActive(false);
        naranja_m.SetActive(true);
        I.SetActive(false);
        M.SetActive(true);
        botonAcierto_3.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_4()
    {
        letra4.SetActive(true);
        alerta.SetActive(true);
        startm = true;
        foto_4.SetActive(true);
        pase4 = true;
        flechaDerecha.SetActive(true);
        naranja_m.SetActive(false);
        M.SetActive(false);
        botonAcierto_4.image.sprite = imagenCorrecto;
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

    public void RespuestaIncorecta_7()
    {
        botonIncorrecto_7.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_8()
    {
        botonIncorrecto_8.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_9()
    {
        botonIncorrecto_9.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_10()
    {

        botonIncorrecto_10.image.sprite = imagenIncorrecto;
    }

    public void RespuestaIncorecta_11()
    {
        botonIncorrecto_11.image.sprite = imagenIncorrecto;

    }
    public void RespuestaIncorecta_12()
    {
        botonIncorrecto_12.image.sprite = imagenIncorrecto;
    }

    public void OpenPanel(GameObject panel)//Método que guarda que has pasado el camino medio
    {
        Debug.Log("Este guarda que has pasado nivel 2");
        LevelCaminoMedio.SetActive(false);
        Info.SetActive(true);
    }

    public void NivelTerminado() //Método que almacena que has terminado el nivel
    {
        caminoTerminado = 1;
    }

    public void ReadStringInput(string s)
    {
        input = s; // Asigna la entrada de texto a la variable input
        Debug.Log(input); // Muestra la entrada de texto en la consola
    }

    public void AbrirMapaP1() //Método que se encarga de abrir el mapa de la primera planta cuando le das al minimapa
    {
        if (mapaP1Activada) //Si presionas el botón una vez y el mapa ya esta activado, entonces se desactivará
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

    public void AbrirMapaP2() //Método que se encarga de abrir el mapa de la segunda planta cuando le das al minimapa
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
