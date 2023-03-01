using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    public GameObject ContactVincent;
    public GameObject PhoneHomePage;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        ContactVincent.SetActive(true);
        PhoneHomePage.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
