using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float speed;
    private float punishTime = 2f;
    Rigidbody2D rb;
    CountdownTimer ct;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ct = FindObjectOfType<CountdownTimer>();
        rb.velocity = transform.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ct.Punish(punishTime);
        }
        Destroy(gameObject);
    }
}


