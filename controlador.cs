using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{

    [SerializeField]
    GameObject flecha;
    float currentPosition;
    //int cont;
    //public GameObject Tension_toggle;
    //bool Valor;

void Start()
{
    //Valor = (Tension_toggle.GetComponent<Tension_toggle>().isOn);
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
