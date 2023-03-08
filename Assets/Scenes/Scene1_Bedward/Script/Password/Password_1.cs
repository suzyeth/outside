using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_1 : MonoBehaviour
{
    public GameObject Password_Second3;
    public GameObject Password1;
    public GameObject Code2;
    
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Password_Second3.SetActive(true);
        Password1.SetActive(false);
        Code2.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
