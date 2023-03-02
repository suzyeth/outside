using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page6Left : MonoBehaviour
{
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page5RightCollider;
    public GameObject Page5LeftCollider;
    public GameObject Page6LeftCollider;

    private void OnMouseDown()
    {
        if (Page6.activeSelf)
        {
            Page6.SetActive(false);
            Page6LeftCollider.SetActive(false);
           

            Page5.SetActive(true);
            Page5RightCollider.SetActive(true);
            Page5LeftCollider.SetActive(true);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
