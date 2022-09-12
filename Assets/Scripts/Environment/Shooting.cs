using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    float timeBetween;
    public GameObject key;
    public float startTimeBetween;
    public Transform firePoint;

    private void Start()
    {
        timeBetween = startTimeBetween;
    }

    private void Update()
    {
        if(timeBetween <= 0)
        {
            Instantiate(key, firePoint.position, firePoint.rotation);
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }
}
