using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVerdeB : MonoBehaviour
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





/*
public class ControladorVerdeB : MonoBehaviour
{
    [SerializeField]
    GameObject flecha;
    float currentPosition;

    int cont;

    void Start()
    {
        currentPosition = transform.position.y;
        cont = 0;

    }



    // Update is called once per frame
    public void ShowHide()
    {
        if ((flecha.activeSelf) && (transform.position.y <= currentPosition - 0.05 || transform.position.y >= currentPosition - 0.05))
        {
            flecha.SetActive(true);

        }
        else if (cont == 1000)
        {
            flecha.SetActive(false);
            cont = 0;

        }
        else
        {
            cont++;
        }

    }
}

*/
