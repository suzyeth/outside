using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Red : MonoBehaviour
{
    public GameObject Diary_Password;
    public GameObject OriginalDiary;
    public GameObject Red;
    public GameObject Purple;
    public GameObject Blue;
    public GameObject Phone1;

    public GameObject RedVersion;

    public GameObject Exit;
    public GameObject YellowVersion;
    public GameObject BlueVersion;

    public GameObject DiaryPage5;

    public GameObject Password1;

    public GameObject DiaryPage1;
    public GameObject DiaryPage1_Clue;

    public static float count = 0;



    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            RedVersion.SetActive(true);
            //Exit.SetActive(true);
            count = 1;

            YellowVersion.SetActive(false);
            BlueVersion.SetActive(false);
        }
        else
        {
            RedVersion.SetActive(false);
            count = 0;
        }
        

       
        

        if(DiaryPage5.activeSelf)
        {
            Password1.SetActive(true);
        }

        if(DiaryPage1.activeSelf)
        {
            DiaryPage1_Clue.SetActive(true);
        }

        //if (OriginalDiary.activeSelf)
        {
            //Diary_Password.SetActive(true);
            //OriginalDiary.SetActive(false);
            //Phone1.SetActive(true);

        }
        //if (Blue.activeSelf)
        {
            //Purple.SetActive(true);
        }
       //Red.SetActive(true);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (YellowVersion.activeSelf)
        {
            count = 0;
        }
        if (BlueVersion.activeSelf)
        {
            count = 0;
        }
    }
}
