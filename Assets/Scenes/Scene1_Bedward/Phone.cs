using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phoneImages;
    public GameObject phonepassword;
    public GameObject Phone_Scene;
    public GameObject Phone_prop;
    public GameObject Phone_prop1;
    public GameObject Exit;
    public GameObject Diary_prop;

    
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        phoneImages.SetActive(true);
        Phone_Scene.SetActive(false);
        
        Exit.SetActive(true);

        if(Diary_prop.activeSelf == false)
        {
            
            Phone_prop1.SetActive(true);
        }

        if(Diary_prop.activeSelf)
        {
            Phone_prop.SetActive(true);
        }
        

        
    }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    
}
