using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatoformDmg : MonoBehaviour
{
    public CountdownTimer countdownTimer;

    private void FixedUpdate()
    {
        var colliders = Physics2D.OverlapBoxAll(transform.position, Vector2.one, 0);
        bool punished = false;
        foreach (var collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {
                punished = true;
            }
        }
        countdownTimer.isPunished = punished;
    }
}
