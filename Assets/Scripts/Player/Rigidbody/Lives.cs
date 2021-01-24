using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Lives
{
    public static PersistentData _data;
    public static Text lifeCount;
    public static GameObject mainUI; //The main level UI
    public static GameObject gameOverCanvas; //The UI that shows when the game is lost

    public static void Die()
    {
        if (_data.lives >= 1)
        {
            AddToLives(-1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public static void AddToLives(int amount)
    {
        _data.lives += amount;
    }
}
