using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{   
    public event Action OnTimeFinished;

    private float timeToFinish = 30f;
    private float currentTime = 30f;
    private Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
    }


    void Update()
    {
        DecreaceTime();
        
        if (currentTime < 0)
        {
            OnTimeFinished?.Invoke();
        }
    }

    private void DecreaceTime()
    {
        image.fillAmount = currentTime / timeToFinish;
        currentTime -= Time.deltaTime;
    }
}
