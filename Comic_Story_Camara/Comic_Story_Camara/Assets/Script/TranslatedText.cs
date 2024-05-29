using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TranslatedText : MonoBehaviour
{

    private LanguageManager lang;
    private TMP_Text myText;

    [Tooltip("The string name (Index) in the XML field.")]
    [SerializeField] private string param;

    void Start()
    {
        lang = LanguageManager.instance;
        // Accede al LanguageManager a trav�s de su instancia �nica.
        LanguageManager.OnLanguageChange += OnLanguageChange;
        // Suscribe el m�todo OnLanguageChange al evento OnLanguageChange del LanguageManager.
        // Esto asegura que el texto se actualice cuando cambie el idioma.
        myText = GetComponent<TMP_Text>();
        // Obtiene el componente TMP_Text adjunto al mismo GameObject o a uno de sus hijos.
        if (lang != null && lang.langReader != null)
        {
            // Verifica si el LanguageManager y su lector de idiomas est�n disponibles.
            UpdateText();
            // Si est�n disponibles, actualiza el texto para reflejar el idioma actual.
        }
    }

    void OnLanguageChange()
    {
        // Este m�todo se llama cuando cambia el idioma.
        if (lang != null && lang.langReader != null)
        {
            // Verifica si el LanguageManager y su lector de idiomas est�n disponibles.
            UpdateText();
            // Si est�n disponibles, actualiza el texto para reflejar el idioma actual.
        }
    }

    void UpdateText()
    {
        // Este m�todo actualiza el texto para reflejar el idioma actual.
        if (myText != null)
        {
            // Si el componente TMP_Text est� presente en este GameObject o en uno de sus hijos.
            myText.text = lang.langReader.getString(param);
            // Obtiene la cadena de texto traducida del LanguageManager y la asigna al componente TMP_Text.
        }
        else if (GetComponent<TextMesh>() != null)
            // Si no hay un componente TMP_Text, pero hay un componente TextMesh presente.
            GetComponent<TextMesh>().text = lang.langReader.getString(param);
        // Obtiene la cadena de texto traducida del LanguageManager y la asigna al componente TextMesh.
    
}

    private void OnDestroy()
    {
        // Este m�todo se llama cuando el GameObject se destruye.
        LanguageManager.OnLanguageChange -= OnLanguageChange;
        // Se cancela la suscripci�n al evento OnLanguageChange para evitar errores de referencia.
    }
}
