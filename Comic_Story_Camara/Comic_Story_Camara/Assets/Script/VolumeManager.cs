using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider; //Llama al Slider

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value; //Cambia el volumen de la musica
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume"); // Salva el volumen de la muscia
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value); //Salva la cancion durante las escenas
    }


}
