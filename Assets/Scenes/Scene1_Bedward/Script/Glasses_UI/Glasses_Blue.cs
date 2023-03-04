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

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        BlueVersion.SetActive(true);
        Exit.SetActive(true);

        if (RedVersion.activeSelf)
        {
            RedVersion.SetActive(false);

        }

        if (YellowVersion.activeSelf)
        {
            YellowVersion.SetActive(false);

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
        
    }
}
