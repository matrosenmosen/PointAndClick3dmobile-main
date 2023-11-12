using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{

    public float sensistivity = 3f;

    private void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * sensistivity;
        float yAxisRotation = Input.GetAxis("Mouse Y") * sensistivity;
        
        transform.Rotate(Vector3.down, xAxisRotation);
        transform.Rotate(Vector3.right, yAxisRotation);

    }


}
