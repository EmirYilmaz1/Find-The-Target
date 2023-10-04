using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseUI : MonoBehaviour
{
    [SerializeField] GameObject loseImage;
    void Start()
    {
        FindObjectOfType<Timer>().OnTimeFinished += () => {loseImage.SetActive(true);};
    }

    
}
