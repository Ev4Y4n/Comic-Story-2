using System;
using System.Collections;
using System.Xml;
using UnityEngine;

// Esta clase es el núcleo, nos permite leer el archivo XML (utilizando System.Xml)
public class LanguageReader
{

    Hashtable XML_Strings; // Declara una variable Hashtable para almacenar las cadenas de texto del archivo XML.
    public LanguageReader(TextAsset xmlFile, string language)
    {
        SetLocalLanguage(xmlFile.text, language);
        //Constructor que recibe un archivo XML (como TextAsset) y un idioma.
        //Llama al método SetLocalLanguage para cargar las cadenas del idioma especificado.
    }

    public void SetLocalLanguage(string xmlContent, string language)
    {
        XmlDocument xml = new XmlDocument();
        //Crea una nueva instancia de XmlDocument para cargar el contenido XML.
        xml.LoadXml(xmlContent);
        //Carga el contenido XML en el XmlDocument.
        XML_Strings = new Hashtable();
        //Inicializa el Hashtable para almacenar las cadenas de texto.
        XmlElement element = xml.DocumentElement[language];
        //Obtiene el elemento XML que corresponde al idioma especificado.
        if (element != null)
        {
            var elemEnum = element.GetEnumerator();
            // Si el elemento del idioma existe, obtiene un enumerador para recorrer sus elementos hijos.

            while (elemEnum.MoveNext())
            {
                XML_Strings.Add((elemEnum.Current as XmlElement).GetAttribute("name"), (elemEnum.Current as XmlElement).InnerText.Replace(@"\n", Environment.NewLine));
                //Convierte el elemento actual del enumerador a XmlElement.
                // Agrega la cadena de texto al Hashtable.
                // Utiliza el atributo "name" como clave y el texto interno del elemento como valor.
                // Reemplaza las secuencias "\n" con saltos de línea reales.
            }
        }
        else
        {
            Debug.LogError("The specified language does not exist: " + language);
            // Si el elemento del idioma no existe, muestra un mensaje de error en el log de Unity.
        }
    }
    public string getString(string _name)
    {
        if (!XML_Strings.ContainsKey(_name))
        {
            Debug.LogWarning("This string is not present in the XML file where you're reading: " + _name);
            // Si la clave no existe en el Hashtable, muestra una advertencia en el log de Unity.
            return "";
            // Retorna una cadena vacía.
        }
        return (string)XML_Strings[_name];
        // Si la clave existe, retorna la cadena correspondiente del Hashtable.
    }

}
