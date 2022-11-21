using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ControladorAmarilloA : MonoBehaviour
{
    [SerializeField]
    GameObject flecha;
    float currentPosition;
    //int cont;
    //public GameObject toggler;
    //bool Valor;

    void Start()
    {
        //Valor = (toggler.GetComponent<Toggle>().isOn);
        //currentPosition = transform.position.y;
        //cont = 0;
        
    }

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
