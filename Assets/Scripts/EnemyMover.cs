using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    void Start()
    {
        PrintWayPointName();
    }

   void PrintWayPointName()
    {
        foreach(WayPoint wayPoint in path)
        {
            Debug.Log(wayPoint.name);
        }
    }
}
