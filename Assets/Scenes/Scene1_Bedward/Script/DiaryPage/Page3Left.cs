using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page3Left : MonoBehaviour
{
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page2RightCollider;
    public GameObject Page3RightCollider;
    public GameObject Page3LeftCollider;

    private void OnMouseDown()
    {
        if (Page3.activeSelf)
        {
            Page3.SetActive(false);
            Page3LeftCollider.SetActive(false);
            Page3RightCollider.SetActive(false);

            Page2.SetActive(true);
            Page2RightCollider.SetActive(true);
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
