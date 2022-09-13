using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunishTime : MonoBehaviour
{
    public CountdownTimer countdownTimer;
    public GameOverPanel gameOverPanel;

    private void FixedUpdate()
    {
        var colliders = Physics2D.OverlapBoxAll((Vector2)transform.position + Vector2.down * 0.6f, Vector2.one, 0);
        bool punished = false;
        foreach(var collider in colliders)
        {
            if (collider.CompareTag("Damage"))
            {
                punished = true;
            }
            if (collider.CompareTag("End"))
            {
                gameOverPanel.Show();
            }
        }
             countdownTimer.isPunished = punished;
    }

}
