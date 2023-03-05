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
    public GameObject BlackSquare;

    public GameObject PhoneLock;
    public GameObject PhoneHomePage;

    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;

    public GameObject BlueVersion;
    public GameObject RedVersion;
    public GameObject YellowVersion;

    public GameObject Password1;
    public GameObject Password2;
    public GameObject Password3;

    public GameObject DiaryPage1_Clue;


    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (OriginalDiary.activeSelf)
        {
            OriginalDiary.SetActive(false);
            //Exit1.SetActive(true);
            Exit_images.SetActive(false);
            Page1.SetActive(false);
            Page2.SetActive(false);
            Page3.SetActive(false);
            Page4.SetActive(false);
            Page5.SetActive(false);
            Page6.SetActive(false);

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

        BlackSquare.SetActive(false);

        if(PhoneLock.activeSelf)
        {
            PhoneLock.SetActive(false);
            Exit_images.SetActive(false);
        }

        if(PhoneHomePage.activeSelf)
        {
            PhoneHomePage.SetActive(false);
            Exit_images.SetActive(false);
        }

        //if(BlueVersion.activeSelf)
        {
            //BlueVersion.SetActive(false);
            //Exit_images.SetActive(false);
        }

        //if (RedVersion.activeSelf)
        {
            //RedVersion.SetActive(false);
            //Exit_images.SetActive(false);
        }

        //if (YellowVersion.activeSelf)
        {
            //YellowVersion.SetActive(false);
            //Exit_images.SetActive(false);
        }

        if(Password1.activeSelf)
        {
            Password1.SetActive(false);
            Exit_images.SetActive(false);
        }

        if (Password2.activeSelf)
        {
            Password2.SetActive(false);
            Exit_images.SetActive(false);
        }

        if (Password3.activeSelf)
        {
            Password3.SetActive(false);
            Exit_images.SetActive(false);
        }

        if(DiaryPage1_Clue.activeSelf)
        {
            DiaryPage1_Clue.SetActive(false);
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
