using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundiskPickupScript : MonoBehaviour
{
    public GameObject mainUICanvas;
    public GameObject levelEndCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0.0f;
            mainUICanvas.SetActive(false);
            levelEndCanvas.SetActive(true);
        }
    }
}
