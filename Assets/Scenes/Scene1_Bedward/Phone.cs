using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phoneImages;
    public GameObject Phone1;
    public GameObject phonepassword;

    int phone = 0;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        phoneImages.SetActive(true);

        if(phoneImages.activeSelf)
        {
            phone = 1;
        }

        if (Phone1.activeSelf && phone == 1)
        {
            phonepassword.SetActive(true);
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
