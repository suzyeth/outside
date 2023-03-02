using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page2Right : MonoBehaviour

{
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page2RightCollider;
    public GameObject Page3RightCollider;
    public GameObject Page3LeftCollider;
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        if (Page2.activeSelf)
        {
            Page2.SetActive(false);
            Page2RightCollider.SetActive(false);

            Page3.SetActive(true);
            Page3RightCollider.SetActive(true);
            Page3LeftCollider.SetActive(true);
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
