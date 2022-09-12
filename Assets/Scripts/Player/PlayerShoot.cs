using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{ 
    public GameObject arrow;
    Vector3 arrowPosDir;
    private Animator anim;
    
    private float shootPointDst = 2f;
    public float shootSpeed;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector2 bowPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        arrowPosDir = (bowPos - (Vector2)transform.position).normalized;

        if(bowPos.x < transform.position.x)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }
    void Shooting()
    {
        GameObject shoot = Instantiate(arrow, transform.position + arrowPosDir * shootPointDst, Quaternion.identity);
        shoot.transform.rotation = Quaternion.LookRotation(Vector3.forward, arrowPosDir * shootPointDst);
        shoot.GetComponent<Rigidbody2D>().AddForce(arrowPosDir * shootSpeed, ForceMode2D.Impulse);
        anim.SetTrigger("Attack");
        Destroy(shoot, 10f);
    }
    
}
