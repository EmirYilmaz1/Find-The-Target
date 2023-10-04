using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public event Action OnTargetChoosed;
    private List<Person> personsList = new List<Person>();
    private int listIndex;
    private Person target;
    void Start()
    {
        FindAllPeople();
        SetTheTarget();    
        print(personsList.Count);
    }


    private void FindAllPeople()
    {
        Person[] persons = FindObjectsOfType<Person>();
        foreach (Person person in persons)
        {
            personsList.Add(person);
        }
    }

    
    private void SetTheTarget()
    {
      listIndex = UnityEngine.Random.Range(0, personsList.Count);
      personsList[listIndex].isTarget = true;    
      target =  personsList[listIndex];
      OnTargetChoosed?.Invoke();
    }

    public Person GetTarget()
    {
        return target;
    }

}
