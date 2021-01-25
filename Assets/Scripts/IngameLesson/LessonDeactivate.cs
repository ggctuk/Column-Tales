using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonDeactivate : MonoBehaviour
{
    public GameObject educationalCanvas;

    public void OnClick()
    {
        Time.timeScale = 1.0f;
        educationalCanvas.SetActive(false);
    }
}
