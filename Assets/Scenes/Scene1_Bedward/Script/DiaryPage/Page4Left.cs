using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page4Left : MonoBehaviour
{
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page3RightCollider;
    public GameObject Page3LeftCollider;
    public GameObject Page4RightCollider;
    public GameObject Page4LeftCollider;

    public GameObject ReftoYellowVersion;
    public GameObject Password2;

    private void OnEnable()
    {
        print(ReftoYellowVersion.name);
        print(ReftoYellowVersion.activeSelf);

        if (ReftoYellowVersion.activeSelf)
        {
            Password2.SetActive(true);
        }
    }
    private void OnMouseDown()
    {
        if (Page4.activeSelf)
        {
            Page4.SetActive(false);
            Page4LeftCollider.SetActive(false);
            Page4RightCollider.SetActive(false);

            Page3.SetActive(true);
            Page3RightCollider.SetActive(true);
            Page3LeftCollider.SetActive(true);
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
