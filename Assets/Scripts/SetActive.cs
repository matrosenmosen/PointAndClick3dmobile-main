using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject setactive;
    public GameObject button;

    public void SetActiveObject()
    {
        setactive.SetActive(!setactive.activeSelf);

        if (setactive.activeSelf)
        {
            button.SetActive(false);
        }

        else 
        { 
            button.SetActive(true); 
        }
    }
}
