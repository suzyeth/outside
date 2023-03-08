using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case_Right : MonoBehaviour
{
    public GameObject Page2;
    public GameObject Page1;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Page2.SetActive(true);
        Page1.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
