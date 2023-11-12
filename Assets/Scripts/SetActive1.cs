using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive1 : MonoBehaviour
{
    public GameObject setactive;

    public void SetActiveObject()
    {
        setactive.SetActive(!setactive.activeSelf);
    }
}
