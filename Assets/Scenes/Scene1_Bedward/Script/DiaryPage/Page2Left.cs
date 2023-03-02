using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page2Left : MonoBehaviour
{
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page1RightCollider;
    public GameObject Page2RightCollider;
    public GameObject Page2LeftCollider;

    private void OnMouseDown()
    {
        if(Page2.activeSelf)
        {
            Page2.SetActive(false);
            Page2LeftCollider.SetActive(false);
            Page2RightCollider.SetActive(false);

            Page1.SetActive(true);
            Page1RightCollider.SetActive(true);
        }



    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
