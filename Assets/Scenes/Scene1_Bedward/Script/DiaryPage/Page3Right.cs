using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page3Right : MonoBehaviour
{
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page3RightCollider;
    public GameObject Page4RightCollider;
    public GameObject Page4LeftCollider;


    private void OnMouseDown()
    {
        if (Page3.activeSelf)
        {
            Page3.SetActive(false);
            Page3RightCollider.SetActive(false);

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
