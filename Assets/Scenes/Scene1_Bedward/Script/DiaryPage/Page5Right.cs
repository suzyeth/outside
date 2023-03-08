using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page5Right : MonoBehaviour
{
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page5RightCollider;
    public GameObject Page6LeftCollider;

    public GameObject ReftoRedVersion;
    public GameObject Password1;

    private void OnEnable()
    {
        print(ReftoRedVersion.name);
        print(ReftoRedVersion.activeSelf);

        if (ReftoRedVersion.activeSelf)
        {
            Password1.SetActive(true);
        }
    }
    private void OnMouseDown()
    {
        if (Page5.activeSelf)
        {
            Page5.SetActive(false);
            Page5RightCollider.SetActive(false);

            Page6.SetActive(true);
            Page6LeftCollider.SetActive(true);
           
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
