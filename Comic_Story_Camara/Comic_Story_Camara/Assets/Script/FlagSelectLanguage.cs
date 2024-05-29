using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagSelectLanguage : MonoBehaviour
{
    //Esta clase se utiliza para las banderas que nos permiten cambiar el idioma.B�sicamente, todo lo que hacemos es llamar a la funci�n "SelectLanguage" del LanguageManager cuando hacemos clic
    //en el bot�n (donde este script est� adjunto)
    //y pasar el par�metro del idioma con lo que hemos escrito en el inspector.

    private LanguageManager lang;
    [SerializeField] private string language;

    void Start()
    {
        lang = LanguageManager.instance;
        // Crear un Listener para la funci�n "SelectLanguage()" presente en LanguageManager.cs
        GetComponent<Button>().onClick.AddListener(() => { lang.SelectLanguage(language); });
    }
}
