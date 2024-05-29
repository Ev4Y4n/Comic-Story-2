using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PalabrasLargo : MonoBehaviour
{
    public static PalabrasLargo THIS; //Variable estatica que permite acceder al script desde otros 
    private string input; // Variable privada que almacena la entrada de texto

    public GameObject paginaC; //variable que contiene la página C
    public GameObject paginaD;
    public GameObject paginaG;
    public GameObject paginaF;
    public GameObject paginaK;
    public GameObject paginaO;

    public GameObject letra1;
    public GameObject letra2;
    public GameObject letra3;
    public GameObject letra4;
    public GameObject letra5;

    public GameObject alerta;

    public GameObject LevelCaminoLargo;

    public GameObject foto_1;
    public GameObject foto_2;
    public GameObject foto_3;
    public GameObject foto_4;
    public GameObject foto_5;

    public Button botonAcierto_1;
    public Button botonAcierto_2;
    public Button botonAcierto_3;
    public Button botonAcierto_4;
    public Button botonAcierto_5;

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
    public Button botonIncorrecto_13;
    public Button botonIncorrecto_14;
    public Button botonIncorrecto_15;
    public Button botonIncorrecto_16;
    public Button botonIncorrecto_17;
    public Button botonIncorrecto_18;
    public Button botonIncorrecto_19;
    public Button botonIncorrecto_20;

    public Sprite imagenCorrecto;
    public Sprite imagenIncorrecto;

    [SerializeField]
    private bool d;
    private bool o;
    private bool startc;
    private bool startd;
    private bool startg;
    private bool startf;
    private bool startk;


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
    public bool pase5 = false;

    public GameObject rojo_c;
    public GameObject rojo_d;
    public GameObject rojo_g;
    public GameObject rojo_f;
    public GameObject rojo_k;

    public GameObject mapaP1;
    public bool mapaP1Activada; //Variable para comprobar si el mapa del piso 1 esta activado o no

    public GameObject mapaP2;
    public bool mapaP2Activada;

    public GameObject botonMinimapaD;
    public GameObject botonMinimapaG;

    public GameObject C; //Variable que contiene el indicador de la pregunta C
    public GameObject D;
    public GameObject G;
    public GameObject F;
    public GameObject K;

    private void Awake()
    {
        THIS = this;
    }
    public void Start()
    {
        C.SetActive(true); //Al prinxipio el indidcador de la pregunta C ya está activo
    }
   public void Update()
   {
      if (LevelInfo.activeSelf == true && startc == true)
      {
         alerta.SetActive(false);// Desactiva la alerta si LevelInfo y start están activados
        }
      

      if (LevelInfo.activeSelf == true && startd == true)
      {
          alerta.SetActive(false);
      }
      

      if (LevelInfo.activeSelf == true && startg == true)
      {
            alerta.SetActive(false);
      }
      
      if (LevelInfo.activeSelf == true && startf == true)
      {
            alerta.SetActive(false);
      }
      
      if (LevelInfo.activeSelf == true && startk == true)
      {
            alerta.SetActive(false);
      }

      if (pase1 == true && pase2 == true && pase3 == true && pase4 == true && pase5 == true && o == false)
      {
         paginaO.SetActive(true);// Activa la página O si todos los pases son verdaderos y o es falso
         flechaDerecha.SetActive(false);// Desactiva la flecha derecha
         flechaIzquierda.SetActive(false); // Desactiva la flecha izquierda
         alerta.SetActive(false);// Desactiva la alerta
         Info.SetActive(false);// Desactiva la información
         Salir.SetActive(false);// Desactiva el botón de salir
         o = true;// Establece o en verdadero
        }
   }

    public void RespuestaCorecta_1() //Método que controla cuando se da al botón de la respuesta correcta
    {
        letra1.SetActive(true); // Activa la letra 1
        alerta.SetActive(true); // Activa la alerta
        startc = true; // Establece startc en verdadero
        foto_1.SetActive(true); // Activa la foto 1
        pase1 = true;// Establece pase1 en verdadero
        rojo_c.SetActive(false);// Desactiva el indicador rojo para c
        rojo_d.SetActive(true);// Desactiva el indicador rojo para d
        C.SetActive(false);// Desactiva el indicador rojo para C
        D.SetActive(true);// Desactiva el indicador rojo para D
        flechaDerecha.SetActive(true);// Activa la flecha derecha
        botonAcierto_1.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_2()
    {
        letra2.SetActive(true);
        alerta.SetActive(true);
        startd = true;
        foto_2.SetActive(true);
        pase2 = true;
        rojo_d.SetActive(false);
        rojo_g.SetActive(true);
        D.SetActive(false);
        botonMinimapaD.SetActive(false);
        botonMinimapaG.SetActive(true);
        G.SetActive(true);
        flechaDerecha.SetActive(true);
        botonAcierto_2.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_3()
    {
        letra3.SetActive(true);
        alerta.SetActive(true);
        startg = true;
        foto_3.SetActive(true);
        pase3 = true;
        rojo_g.SetActive(false);
        rojo_f.SetActive(true);
        G.SetActive(false);
        F.SetActive(true);
        flechaDerecha.SetActive(true);
        botonAcierto_3.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_4()
    {
        letra4.SetActive(true);
        alerta.SetActive(true);
        startf = true;
        foto_4.SetActive(true);
        pase4 = true;
        rojo_f.SetActive(false);
        rojo_k.SetActive(true);
        F.SetActive(false);
        K.SetActive(true);
        flechaDerecha.SetActive(true);
        botonAcierto_4.image.sprite = imagenCorrecto;
    }

    public void RespuestaCorecta_5()
    {
        letra5.SetActive(true);
        alerta.SetActive(true);
        startk = true;
        foto_5.SetActive(true);
        pase5 = true;
        rojo_k.SetActive(false);
        K.SetActive(false);
        flechaDerecha.SetActive(true);
        botonAcierto_5.image.sprite = imagenCorrecto;
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

    public void RespuestaIncorecta_13()
    {
        botonIncorrecto_13.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_14()
    {
        botonIncorrecto_14.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_15()
    {
        botonIncorrecto_15.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_16()
    {
        botonIncorrecto_16.image.sprite = imagenIncorrecto;
    }

    public void RespuestaIncorecta_17()
    {
        botonIncorrecto_17.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_18()
    {
        botonIncorrecto_18.image.sprite = imagenIncorrecto;
    }

    public void RespuestaIncorecta_19()
    {
        botonIncorrecto_19.image.sprite = imagenIncorrecto;
    }
    public void RespuestaIncorecta_20()
    {
        botonIncorrecto_20.image.sprite = imagenIncorrecto;
    }

    public void OpenPanel(GameObject panel)//Método que guarda que has pasado el camino medio
    {
      LevelCaminoLargo.SetActive(false);
      Info.SetActive(true);
    }

    public void NivelTerminado()//Método que almacena que has terminado el nivel
    {
        caminoTerminado = 1;
    }

    public void ReadStringInput(string s)
    {
      input = s;// Asigna la entrada de texto a la variable input
      Debug.Log(input);// Muestra la entrada de texto en la consola
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
