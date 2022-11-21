using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorRojo : MonoBehaviour
{
    [SerializeField]
    GameObject flecha;
    GameObject flecha2;


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
