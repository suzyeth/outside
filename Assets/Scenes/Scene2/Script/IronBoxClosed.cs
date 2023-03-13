using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBoxClosed : MonoBehaviour
{
    public GameObject cabinbox;
    public GameObject poster;


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
        cabinbox.SetActive(false);
        poster.SetActive(true);
    }
}
