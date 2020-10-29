using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    float curVolume;
    public GameObject optionsCanvas;
    public GameObject mainMenuCanvas;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        curVolume = volume;
    }

    public void FullScreenMode (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    //For exiting the options menu and returning to the main menu - moved from OptionsMenuHider.
    public void OnClick()
    {
        SaveOptions();
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }

    //Now to save these settings
    public void SaveOptions()
    {
        PlayerPrefs.SetInt("FullScreenSetting", Convert.ToInt32(Screen.fullScreen)); //Converts the Full Screen Yes/No option to an integer and stores it
        PlayerPrefs.SetFloat("VolumeSetting", curVolume); //Stores the volume setting
    }
}
