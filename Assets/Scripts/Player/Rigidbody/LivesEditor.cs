using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesEditor : MonoBehaviour
{
    public PersistentData _data;
    public Text uiLifeCounter;
    public GameObject mainUI; //The main level UI
    public GameObject gameOverCanvas; //The UI that shows when the game is lost
    // Start is called before the first frame update
    void Start()
    {
        uiLifeCounter.text = "" + _data.lives;
        Lives._data = _data;
        Lives.lifeCount = uiLifeCounter;
        Lives.mainUI = mainUI;
        Lives.gameOverCanvas = gameOverCanvas;
    }
}
