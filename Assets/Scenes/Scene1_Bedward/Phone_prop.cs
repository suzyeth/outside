using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_prop : MonoBehaviour
{
    public GameObject Phone_Scene;
    public GameObject PhoneProp;
    public GameObject Phone_Password;
    public GameObject PhoneImages;
    public GameObject Exit;

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        //Phone_Password.SetActive(true);
        Exit.SetActive(true);
        PhoneImages.SetActive(true);

        
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
