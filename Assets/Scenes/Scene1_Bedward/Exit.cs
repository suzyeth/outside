using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject OriginalDiary;
    public GameObject Diary_Password;
    public GameObject Exit1;
    public GameObject Exit_images;
    public GameObject PhoneImages;
 


    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (OriginalDiary.activeSelf)
        {
            OriginalDiary.SetActive(false);
            //Exit1.SetActive(true);
            Exit_images.SetActive(false);
        }

        if(Diary_Password.activeSelf)
        {
            Diary_Password.SetActive(false);
            //Exit1.SetActive(true);
            Exit_images.SetActive(false);
        }

       if(PhoneImages.activeSelf)
        {
            PhoneImages.SetActive(false);
            Exit_images.SetActive(false);
        }
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0) && OriginalDiary == true)
        {
            //OriginalDiary.SetActive(false);
        }
        
    }
}
