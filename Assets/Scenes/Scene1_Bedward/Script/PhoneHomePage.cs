using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneHomePage : MonoBehaviour
{
    public GameObject Code;
    public GameObject PhoneHomePage1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PhoneHomePage1.activeSelf)
        {
            Code.SetActive(false);
        }
    }
}
