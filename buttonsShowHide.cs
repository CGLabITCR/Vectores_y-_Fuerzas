using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsShowHide : MonoBehaviour
{

    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (arrow.activeInHierarchy == true)
            arrow.SetActive(false);
        else
            arrow.SetActive(true);
    }
}
