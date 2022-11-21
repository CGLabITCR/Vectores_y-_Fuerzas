using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAzulA : MonoBehaviour
{
    [SerializeField]
    GameObject img;
    //

    // Update is called once per frame
    public void ShowHide()
    {
        if (img.activeSelf)
        {
            img.SetActive(true);

        }
        else
        {
            img.SetActive(true);

        }

    }
}

