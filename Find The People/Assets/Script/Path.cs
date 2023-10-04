using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> wayPoints = new List<Transform>();
    
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        foreach(Transform transform in transform)
        {
            Gizmos.DrawWireSphere(transform.position,.4f);
        }

        for(int i = 0; i<wayPoints.Count; i++)
        {
            if(GetNextIndex(i)==wayPoints.Count)
            {
                 Gizmos.DrawLine(wayPoints[i].position,wayPoints[0].position);
                 continue;
            }

            Gizmos.DrawLine(wayPoints[i].position,wayPoints[GetNextIndex(i)].position);
        }
        
    }

    public int GetNextIndex(int index)
    {
       return index +1;
    }


    public bool CheckNextWaypoint(int index)
    {
        if(index == wayPoints.Count)
        {
            return false;
        }
        
        return true;
    }

    public int SetPathIndex(int a)
    {
        if(!CheckNextWaypoint(a))
        {
            return 0;
        }
        
        return a+1;
    }


}
