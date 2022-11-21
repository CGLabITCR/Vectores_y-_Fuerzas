using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerarDCLC : MonoBehaviour
{
    [SerializeField]
    GameObject img1;

    public void ShowHide()
    {
        if (img1.activeSelf)
        {
            img1.SetActive(false);

        }
        else
        {
            img1.SetActive(true);

        }

    }
}
