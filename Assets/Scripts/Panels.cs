using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    public GameObject[] images;

    private int panelIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PanelImage(int step)
    {
        panelIndex += step;

        if (panelIndex >= images.Length)
        {
            panelIndex = 0;
        }
        else if (panelIndex < 0)
        {
            panelIndex = images.Length - 1;
        }
    }
}
