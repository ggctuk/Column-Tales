using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNewGame : MonoBehaviour
{
    public string stageName;

    public void OnClick ()
    {
        SceneManager.LoadScene(stageName);
    }
}
