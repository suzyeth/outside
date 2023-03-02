using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLockVersion : MonoBehaviour
{
    public GameObject PhoneLock;
    public GameObject PhoneLockVersion1;
    public GameObject Exit_images;
    public GameObject Password_0;



    // Start is called before the first frame update


    private void OnMouseDown()
    {
        PhoneLock.SetActive(true);
        PhoneLockVersion1.SetActive(false);
        Exit_images.SetActive(true);
        Password_0.SetActive(true);
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
