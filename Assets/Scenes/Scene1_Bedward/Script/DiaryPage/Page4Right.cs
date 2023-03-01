using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page4Right : MonoBehaviour
{
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page4RightCollider;
    public GameObject Page5RightCollider;
    public GameObject Page5LeftCollider;


    private void OnMouseDown()
    {
        if (Page4.activeSelf)
        {
            Page4.SetActive(false);
            Page4RightCollider.SetActive(false);

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

