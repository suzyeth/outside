using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_3 : MonoBehaviour
{
    public GameObject Password_1;
    public GameObject Password3;
    public GameObject Code1;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Password_1.SetActive(true);
        Password3.SetActive(false);
        Code1.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
