using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRojoA : MonoBehaviour
{
    [SerializeField]
    GameObject flecha;


    // Update is called once per frame
    public void ShowHide()
    {
        if (flecha.activeSelf)
        {
            flecha.SetActive(true);

        }
        else
        {
            flecha.SetActive(true);

        }

    }
}
