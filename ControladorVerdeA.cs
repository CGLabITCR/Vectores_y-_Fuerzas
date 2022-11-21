using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVerdeA : MonoBehaviour
{
    [SerializeField]
    GameObject flecha;


    // Update is called once per frame
    public void ShowHide()
    {
        if (flecha.activeSelf)
        {
            flecha.SetActive(false);

        }
        else
        {
            flecha.SetActive(true);

        }

    }
}
