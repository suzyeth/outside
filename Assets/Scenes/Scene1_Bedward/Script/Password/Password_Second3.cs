using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_Second3 : MonoBehaviour
{
    public GameObject PhoneHomePage;
    public GameObject Password_3_2;
    public GameObject Code3;
    public GameObject PhoneLockPage;
    public GameObject Contact;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        PhoneHomePage.SetActive(true);
        Code3.SetActive(true);
        Password_3_2.SetActive(false);
        PhoneLockPage.SetActive(false);
        Contact.SetActive(true);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
