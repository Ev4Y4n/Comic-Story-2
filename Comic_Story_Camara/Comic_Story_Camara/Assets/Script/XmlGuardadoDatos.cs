using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class XmlGuardadoDatos : MonoBehaviour
{
    private string fileName = "GuardarDatos.xml";
    private string filePath;

    public PalabrasCorto scriptCaminoCorto;
    public PalabrasMedio scriptCaminoMedio;
    public PalabrasLargo scriptCaminoLargo;

    public int facil;
    public int normal;
    public int dificil;

    public int escena;

    //public GameObject boton1;
    //public GameObject botones;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, fileName);

        if (!File.Exists(filePath) && escena==1)
        {
            CrearXML();
        }
        else if (File.Exists(filePath) && escena == 1)
        {
            //botones.SetActive(true);
            //boton1.SetActive(false);
            LeerXML();
        }
       

    }

    public void DeleteXMLFile()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);

        }
        SceneManager.LoadSceneAsync(1);

    }


    public void CrearXML()
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlElement root = xmlDoc.CreateElement("Datos");
        xmlDoc.AppendChild(root);
        XmlElement caminoFacil = xmlDoc.CreateElement("CaminoFacil");
        root.AppendChild(caminoFacil);
        caminoFacil.InnerText = scriptCaminoCorto.caminoTerminado.ToString();

        XmlElement caminoMedio = xmlDoc.CreateElement("CaminoMedio");
        root.AppendChild(caminoMedio);
        caminoMedio.InnerText = scriptCaminoMedio.caminoTerminado.ToString();

        XmlElement caminoLargo = xmlDoc.CreateElement("CaminoLargo");
        root.AppendChild(caminoLargo);
        caminoLargo.InnerText = scriptCaminoLargo.caminoTerminado.ToString();

        xmlDoc.Save(filePath);
    }

    public void LeerXML()
    {
        Debug.Log("Se lee el xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(filePath);
        XmlNodeList nodes = xmlDoc.SelectNodes("Datos/CaminoFacil");
        XmlNodeList nodes1 = xmlDoc.SelectNodes("Datos/CaminoMedio");
        XmlNodeList nodes2 = xmlDoc.SelectNodes("Datos/CaminoLargo");

        foreach (XmlNode node in nodes)
        {
            facil = int.Parse(node.InnerText);
        }

        foreach (XmlNode node1 in nodes1)
        {
            normal = int.Parse(node1.InnerText);
        }
        foreach (XmlNode node2 in nodes2)
        {
            dificil = int.Parse(node2.InnerText);
        }
    }
}
