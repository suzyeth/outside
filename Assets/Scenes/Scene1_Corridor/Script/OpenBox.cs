using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
   
    public GameObject Cabinet;
    public GameObject OtherCabinet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        Cabinet.SetActive(true);
        OtherCabinet.SetActive(false);


    }

}
