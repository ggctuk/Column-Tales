using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuHider : MonoBehaviour
{
    public GameObject optionsCanvas;
    public GameObject mainMenuCanvas;

    public void OnClick ()
    {
        optionsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
