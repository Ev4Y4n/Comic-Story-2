using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Caminos : MonoBehaviour
{
    [Header("Panels")]
    public GameObject LevelCaminoCorto; //Variable para llamar al Objeto que queramos que sea LevelCaminoCorto
    public GameObject LevelCaminoMedio;
    public GameObject LevelCaminoLargo;
    public GameObject LevelInfo;
    public GameObject BottonInfo;
    public GameObject AtrasInfo;
    public GameObject Alerta;
    public GameObject CaminoCortoViñeta;
    public GameObject CaminoMedioViñeta;
    public GameObject CaminoLargoViñeta;
    public GameObject Opciones;

   

    public void CortoViñetaPanel(GameObject panel)
    {
        CaminoCortoViñeta.SetActive(false);
        panel.SetActive(true);
    }

    public void MedioViñetaPanel(GameObject panel)
    {
        CaminoMedioViñeta.SetActive(false);
        panel.SetActive(true);
    }

    public void LargoViñetaPanel(GameObject panel)
    {
        CaminoLargoViñeta.SetActive(false);
        panel.SetActive(true);
    }
    public void ClosePanelViñetas(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void CortoCaminoPanel(GameObject panel)
    {
        LevelCaminoCorto.SetActive(true);
        CaminoCortoViñeta.SetActive(false);

        panel.SetActive(true);
    }
    public void MedioCaminoPanel(GameObject panel)
    {
        LevelCaminoMedio.SetActive(true);
        CaminoMedioViñeta.SetActive(false);

        panel.SetActive(true);
    }
    public void LargoCaminoPanel(GameObject panel)
    {
        LevelCaminoLargo.SetActive(true);
        CaminoLargoViñeta.SetActive(false);

        panel.SetActive(true);
    }

    public void InfoPanel(GameObject panel)
    {
        LevelInfo.SetActive(true);
        BottonInfo.SetActive(false);
        panel.SetActive(true);
    }

    public void ClosePanelInfo(GameObject panel)
    {
        AtrasInfo.SetActive(true);
        BottonInfo.SetActive(true);
        panel.SetActive(false);
    }

    public void OpcionesPanel(GameObject panel)
    {
        Opciones.SetActive(true);
        LevelInfo.SetActive(false);

        panel.SetActive(true);
    }

    public void ClosePanelOpciones(GameObject panel)
    {
        LevelInfo.SetActive(true);
        Opciones.SetActive(false);

        panel.SetActive(true);
    }

    public void ClosePanelCorto(GameObject panel)
    {
        LevelCaminoCorto.SetActive(false);

        panel.SetActive(true);
        PalabrasCorto.THIS.mapaP1.SetActive(false);
        PalabrasCorto.THIS.mapaP2.SetActive(false);
    }

    public void ClosePanelMedio(GameObject panel)
    {
        LevelCaminoMedio.SetActive(false);

        panel.SetActive(true);
        PalabrasCorto.THIS.mapaP1.SetActive(false);
        PalabrasCorto.THIS.mapaP2.SetActive(false);
    }

    public void ClosePanelLargo(GameObject panel)
    {
        LevelCaminoLargo.SetActive(false);

        panel.SetActive(true);
        PalabrasCorto.THIS.mapaP1.SetActive(false);
        PalabrasCorto.THIS.mapaP2.SetActive(false);
    }

    public void MainMenuLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

 

}
