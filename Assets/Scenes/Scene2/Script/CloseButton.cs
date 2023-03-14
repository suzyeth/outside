using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject buttonopen;
    public GameObject buttonclose;
    public GameObject page;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (page.activeSelf == true)
        {
            buttonopen.SetActive(true);
            buttonclose.SetActive(false);
            


        }
        
       
    }
}
