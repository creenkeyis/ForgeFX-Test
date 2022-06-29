using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    //list of materials for highlight
    private List<Renderer> rendMats = new List<Renderer>();

    private void Start()
    {
        rendMats.AddRange(GetComponentsInChildren<Renderer>());
    }

    private void OnMouseEnter()
    {
        foreach (Renderer _r in rendMats)
        {
            _r.material.color = Color.yellow;
        }
    }

    private void OnMouseExit()
    {
        foreach (Renderer rM in rendMats)
        {
            rM.material.color = Color.white;
        }
    }
}
