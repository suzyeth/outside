using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Yellow : MonoBehaviour
{

    public GameObject YellowVersion;
    public GameObject Exit;

    public GameObject BlueVersion;
    public GameObject RedVersion;

    public GameObject DiaryPage4;
    public GameObject Password2;

    public GameObject DiaryPage1;
    public GameObject DiaryPage1_Clue;

    public static float count = 0;

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            YellowVersion.SetActive(true);
            count += 1;

            BlueVersion.SetActive(false);
            RedVersion.SetActive(false);

            if (DiaryPage4.activeSelf && YellowVersion.activeSelf)
            {
                Password2.SetActive(true);
            }

            if (DiaryPage1.activeSelf)
            {
                //DiaryPage1_Clue.SetActive(true);
            }
        }
        else
        {
            YellowVersion.SetActive(false);
          
            Password2.SetActive(false);
            DiaryPage1_Clue.SetActive(false);
            
            count = 0;

        }

        

    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (BlueVersion.activeSelf)
        {
            count = 0;
        }
        if (RedVersion.activeSelf)
        {
            count = 0;
        }
    }
}
