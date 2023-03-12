using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Blue : MonoBehaviour
{
    public GameObject Diary_Password;
    public GameObject OriginalDiary;
    public GameObject Red;
    public GameObject Purple;
    public GameObject Blue;

    public GameObject BlueVersion;
    public GameObject Exit;

    public GameObject RedVersion;
    public GameObject YellowVersion;

    public GameObject DiaryPage6;
    public GameObject Password3;

    public GameObject DiaryPage1;
    public GameObject DiaryPage1_Clue;

    public static float count = 0;

    public GameObject Blue_Clue;

    // Start is called before the first frame update

    private void OnMouseDown()
    {

        if (count == 0)
        {
            BlueVersion.SetActive(true);
            //Exit.SetActive(true);
            count = 1;
            Blue_Clue.SetActive(true);
            if (DiaryPage6.activeSelf && BlueVersion.activeSelf)
            {
                Password3.SetActive(true);
            }

            YellowVersion.SetActive(false);
            RedVersion.SetActive(false);
        }
        else
        {
            BlueVersion.SetActive(false);
            Blue_Clue.SetActive(false);
            count = 0;
        }
        

        if (DiaryPage6.activeSelf)
        {
            Password3.SetActive(true);
        }

        if (DiaryPage1.activeSelf)
        {
            DiaryPage1_Clue.SetActive(true);
        }

        //if (OriginalDiary.activeSelf)
        {
            
            //OriginalDiary.SetActive(false);
        }

        //if(Red.activeSelf)
        {
            //Purple.SetActive(true);
        }

        //Blue.SetActive(true);
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
            Blue_Clue.SetActive(false);
        }
        if (RedVersion.activeSelf)
        {
            count = 0;
            Blue_Clue.SetActive(false);
        }
    }
}
