using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calling : MonoBehaviour
{
    public GameObject Text_Vincent;
    public GameObject DialogePanel;
    public GameObject Dialoge_Vincent;
    public GameObject Exit;
    public GameObject Doctor;
    public GameObject Phone_Contact;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        //Text_Vincent.SetActive(true);
        //DialogePanel.SetActive(true);
        //Dialoge_Vincent.SetActive(true);
        Doctor.SetActive(true);
        Phone_Contact.SetActive(false);
        Exit.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
