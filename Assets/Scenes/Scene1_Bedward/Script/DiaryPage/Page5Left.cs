using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page5Left : MonoBehaviour
{
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page4RightCollider;
    public GameObject Page4LeftCollider;
    public GameObject Page5RightCollider;
    public GameObject Page5LeftCollider;

    private void OnMouseDown()
    {
        if (Page5.activeSelf)
        {
            Page5.SetActive(false);
            Page5LeftCollider.SetActive(false);
            Page5RightCollider.SetActive(false);

            Page4.SetActive(true);
            Page4RightCollider.SetActive(true);
            Page4LeftCollider.SetActive(true);
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
