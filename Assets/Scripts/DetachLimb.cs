using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetachLimb : MonoBehaviour
{
    private float zCoordinate = 0.0f;
    private Vector3 startPos;
    public float distFromOrigin;
    public static bool detached = false;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        zCoordinate = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    private Vector3 MouseToWorldPoint()
    {
        Vector3 mouseCoord = Input.mousePosition;
        mouseCoord.z = zCoordinate;

        return Camera.main.ScreenToWorldPoint(mouseCoord);
    }

    private void OnMouseDrag()
    {
        transform.position = MouseToWorldPoint();
    }

    private void OnMouseUp()
    {
        if(Vector3.Distance(transform.localPosition, startPos) <= distFromOrigin)
        {
            transform.localPosition = startPos;
            detached = false;
            if(transform.name != "Robot_Torso")
            {
                text.text = transform.name + " Attached";
            }
        }
        else
        {
            detached = true;
            if (transform.name != "Robot_Torso")
            {
                text.text = transform.name + " Detached";
            }
        }
    }

    private void OnMouseExit()
    {
        text.text = " ";
    }

    private void OnMouseEnter()
    {
        if(transform.name == "Robot_Torso")
        {
            text.text = transform.name;
        }
        else if (!detached)
        {
            text.text = transform.name + " Attached";
        }
        else
        {
            text.text = transform.name + " Detached";
        }
    }
}
