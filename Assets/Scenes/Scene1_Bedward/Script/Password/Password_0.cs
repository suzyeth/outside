using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_0 : MonoBehaviour
{
    public GameObject Password_3;
    public GameObject Password0;
    public GameObject Code;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Password_3.SetActive(true);
        Password0.SetActive(false);
        Code.SetActive(true);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
