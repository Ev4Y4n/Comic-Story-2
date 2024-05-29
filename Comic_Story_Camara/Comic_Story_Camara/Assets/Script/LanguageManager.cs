using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;
using System.IO;

public class LanguageManager : MonoBehaviour
{
    //Instance es una variable estática que permite implementar el patrón singleton, asegurando que solo exista una instancia de LanguageManager.
    [Header("Languages")]
    public static LanguageManager instance;

    //langReader es una propiedad de solo lectura (externamente) que almacena la instancia de LanguageReader, la cual se encarga de leer el contenido del archivo XML del idioma seleccionado.
    public LanguageReader langReader { get; private set; }

    //currentLanguage almacena el idioma actualmente seleccionado.
    public string currentLanguage = "English";

    //Se define un delegado LanguageChange y un evento estático OnLanguageChange. Otros componentes pueden suscribirse a este evento para ser notificados cuando el idioma cambie.
    public delegate void LanguageChange();
    public static event LanguageChange OnLanguageChange;

    private void Awake() //El método Awake se llama cuando la instancia del script se carga por primera vez.
                         //Aquí se implementa el patrón singleton.Si instance es null, se asigna la instancia actual y se marca el objeto para no ser destruido al cargar una nueva escena.
                         //Luego, se llama a OpenLocalXML para cargar el idioma inicial.Si ya existe una instancia, el objeto actual se destruye para mantener solo una instancia.
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            OpenLocalXML(currentLanguage);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    public void OpenLocalXML(string language)//OpenLocalXML carga un archivo XML basado en el idioma proporcionado.
                                             //Inicialmente, langReader y currentLanguage seestablecen en null para asegurarse de que se carguen nuevos valores.
                                             //Dependiendo del idioma, se carga el archivo correspondiente desde la carpeta Resources.
                                             //Si el idioma no es reconocido, se carga el archivo en inglés por defecto y se muestra una advertencia en el editor de Unity.
                                             //Finalmente,currentLanguage se actualiza y se invoca el evento OnLanguageChange si hay suscriptores.
    {
        langReader = null;
        currentLanguage = null;

        switch (language)
        {
            case "English":
                langReader = new LanguageReader(Resources.Load("Lang/Eng") as TextAsset, "English");
                break;
            case "Espanol":
                langReader = new LanguageReader(Resources.Load("Lang/Esp") as TextAsset, "Espanol");
                break;
            default:
#if UNITY_EDITOR
                Debug.LogWarning("This language doesn't exist: " + language);
#endif
                langReader = new LanguageReader(Resources.Load("Lang/ENG") as TextAsset, "English");
                break;
        }

        currentLanguage = language;
        if (OnLanguageChange != null)
        {
            OnLanguageChange();
        }
    }

    public void SelectLanguage(string language) //SelectLanguage permite cambiar el idioma solo si es diferente del idioma actual. Si es diferente, se llama a OpenLocalXML para cargar el nuevo idioma.
    {
        if (language != currentLanguage)
        {
            OpenLocalXML(language); 
        }

    }
}
