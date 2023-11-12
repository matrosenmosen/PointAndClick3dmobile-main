using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraMovement1 : MonoBehaviour
{

    public Slider scaleslider;

    private float scaleSliderNumber;

    private void Update()
    {
        scaleSliderNumber = scaleslider.value;
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;
    }
}
