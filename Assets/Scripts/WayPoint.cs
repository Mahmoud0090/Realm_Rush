using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlacable = false;
    private void OnMouseDown()
    {
        if (isPlacable)
        {
           Debug.Log(transform.name);
        }
    }
}
