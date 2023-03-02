using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page1Right : MonoBehaviour
{
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page1RightCollider;
    public GameObject Page2RightCollider;
    public GameObject Page2LeftCollider;
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        if(Page1.activeSelf)
        {
            Page1.SetActive(false);
            Page1RightCollider.SetActive(false);

            Page2.SetActive(true);
            Page2RightCollider.SetActive(true);
            Page2LeftCollider.SetActive(true);
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
