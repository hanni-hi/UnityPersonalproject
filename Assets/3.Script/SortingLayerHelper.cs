using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class SortingLayerHelper : MonoBehaviour
{
    public string sortingLayerName = "Default";
    public int sortingOrder = 0;

    void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.sortingLayerName = sortingLayerName;
        renderer.sortingOrder = sortingOrder;
    }
}
