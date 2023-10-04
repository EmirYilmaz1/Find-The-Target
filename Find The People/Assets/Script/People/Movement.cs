using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    [SerializeField] private Path path;

    private NavMeshAgent navMeshAgent;
    private int currentIndex = 0;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       MoveToWayPoint();
    }

    private void MoveToWayPoint()
    {
        if(path.CheckNextWaypoint(currentIndex) && 0.5f<Vector3.Distance(transform.position, path.wayPoints[currentIndex].position))
        {
            navMeshAgent.SetDestination(path.wayPoints[currentIndex].position);
        }
        else
        {
            currentIndex =  path.SetPathIndex(currentIndex);
        }

    }
}
