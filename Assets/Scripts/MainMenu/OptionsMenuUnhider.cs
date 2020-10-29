using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuUnhider : MonoBehaviour
{
    public GameObject optionsCanvas;
    public GameObject mainMenuCanvas;

    public void OnClick()
    {
        optionsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }
}
