using UnityEngine;

public class LessonActive : MonoBehaviour
{

    public GameObject educationalCanvas;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            Time.timeScale = 0.0f;
            educationalCanvas.SetActive(true);
        }
    }
}
