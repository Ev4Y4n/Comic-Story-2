using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagSelectLanguage : MonoBehaviour
{
    //Esta clase se utiliza para las banderas que nos permiten cambiar el idioma.Básicamente, todo lo que hacemos es llamar a la función "SelectLanguage" del LanguageManager cuando hacemos clic
    //en el botón (donde este script está adjunto)
    //y pasar el parámetro del idioma con lo que hemos escrito en el inspector.

    private LanguageManager lang;
    [SerializeField] private string language;

    void Start()
    {
        lang = LanguageManager.instance;
        // Crear un Listener para la función "SelectLanguage()" presente en LanguageManager.cs
        GetComponent<Button>().onClick.AddListener(() => { lang.SelectLanguage(language); });
    }
}
