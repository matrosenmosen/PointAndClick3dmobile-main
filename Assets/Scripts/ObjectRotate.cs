using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{

    public float sensistivity = 3f;
    public float touchSensitivity = 3f;

    private void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * sensistivity;
        float yAxisRotation = Input.GetAxis("Mouse Y") * sensistivity;
        
        if (Input.touchCount > 0) 
        {
            xAxisRotation = Input.touches[0].deltaPosition.x / touchSensitivity;
            yAxisRotation = Input.touches[0].deltaPosition.y / touchSensitivity;
        }

        transform.Rotate(Vector3.down, xAxisRotation);
        transform.Rotate(Vector3.right, yAxisRotation);

        Debug.Log("rotates");

    }

}
