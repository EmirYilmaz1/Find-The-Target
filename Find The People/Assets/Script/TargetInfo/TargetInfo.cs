using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetInfo : MonoBehaviour
{
    private TargetGenerator targetGenerator;
    private PeopleType targetType;
    void Awake()
    {
        targetGenerator = FindObjectOfType<TargetGenerator>();
        targetGenerator.OnTargetChoosed += WriteTargetInfo;
    }

    private void WriteTargetInfo()
    {
        targetType = targetGenerator.GetTarget().peopleType;
        transform.Find("Gender").GetComponent<TextMeshProUGUI>().text = $"Gender: {targetType.gender}";
        transform.Find("Hair").GetComponent<TextMeshProUGUI>().text = $"Hair: {targetType.hairColor}";
        transform.Find("Wearing").GetComponent<TextMeshProUGUI>().text = $"Wearing: {targetType.under}";
        
    }
}
