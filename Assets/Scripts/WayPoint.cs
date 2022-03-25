using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlacable = false;
    [SerializeField] GameObject towerPrefab;
    private void OnMouseDown()
    {
        if (isPlacable)
        {
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlacable = false;
        }
    }
}
