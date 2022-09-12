using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] float knockBackForce = 15f;
    [SerializeField] float knockBackLength = 1f;


    public void StartKnockBack()
    {
        Vector2 translation = Vector2.up * knockBackForce;
        StartCoroutine(DoKnockBack(translation, 5f));
    }
    IEnumerator DoKnockBack(Vector2 translation, float speed)
    {
        Vector2 destination = (Vector2)transform.position + translation;
        while((Vector2)transform.position != destination)
        {
            transform.Translate(translation);
            yield return null;
        }
    }

}
