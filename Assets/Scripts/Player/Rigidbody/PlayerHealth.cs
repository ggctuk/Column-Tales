using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public GameObject gameOverCanvas;
    public Slider healthBar;

    //Update the health bar to whatever the player's current health value is
    private void Update()
    {
        healthBar.value = (float)health / (float)totalHealth;
    }

    public override void Die()
    {
        Time.timeScale = 0.0f;
        gameOverCanvas.SetActive(true);
    }

}
