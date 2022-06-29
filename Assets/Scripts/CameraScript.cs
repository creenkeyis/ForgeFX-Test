using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //robot reference transform
    public Transform robTransform;
    public float camSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CameraMovement());
    }

    IEnumerator CameraMovement()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.RotateAround(robTransform.position, robTransform.up, camSpeed * Input.GetAxis("Horizontal"));
            yield return null;
        }
    }
}
