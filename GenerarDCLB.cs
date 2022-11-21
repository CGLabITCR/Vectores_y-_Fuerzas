using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerarDCLB : MonoBehaviour
{
    [SerializeField]
    GameObject img1;
    [SerializeField]
    GameObject img2;
    [SerializeField]
    GameObject img3;
    [SerializeField]
    GameObject img4;
    [SerializeField]
    GameObject objSelectorAngulo;
    Dropdown selectorAngulo;

    void Start()
    {
        selectorAngulo = objSelectorAngulo.GetComponent<Dropdown>();
    }

    // Update is called once per frame
    public void ShowHide()
    {
        int valor = selectorAngulo.value;
        if (valor == 0)
        {
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            if (img1.activeSelf)
            {
                img1.SetActive(false);

            }
            else
            {
                img1.SetActive(true);

            }
        }
        else if (valor == 1)
        {
            img1.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            if (img2.activeSelf)
            {
                img2.SetActive(false);

            }
            else
            {
                img2.SetActive(true);

            }
        }
        else if (valor == 2)
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img4.SetActive(false);
            if (img3.activeSelf)
            {
                img3.SetActive(false);

            }
            else
            {
                img3.SetActive(true);

            }
        }
        else if (valor == 3)
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            if (img4.activeSelf)
            {
                img4.SetActive(false);

            }
            else
            {
                img4.SetActive(true);

            }
        }


    }
}
