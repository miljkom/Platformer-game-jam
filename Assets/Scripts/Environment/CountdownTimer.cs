using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 0f;
    public float punishTime = 5f;
    public bool isPunished = false;
    [SerializeField] Text countdownText;
    private void Start()
    {
        currentTime = startingTime;
    }
    private void Update()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (isPunished)
        {
            currentTime += punishTime * Time.deltaTime;
            countdownText.color = Color.red;
        }
        else
        {
            countdownText.color = Color.white;
        }
        countdownText.text = currentTime.ToString("F2");
    }
    public void Punish(float punishTime)
    {
        currentTime += punishTime;
    }
}
