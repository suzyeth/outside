using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePassword1 : MonoBehaviour
{
    public GameObject Password1;
    public GameObject DiaryPage3;
    public GameObject DiaryPage5;

    public GameObject YellowVersion;
    public GameObject DiaryPage4;

    public GameObject BlueVersoin;
    public GameObject RedVersion;
    
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DiaryPage3.activeSelf)
        {
            Password1.SetActive(false);

        }

        if (DiaryPage5.activeSelf)
        {
            Password1.SetActive(false);

        }

        if(YellowVersion.activeSelf && DiaryPage4.activeSelf)
        {
            Password1.SetActive(true);
        }
        else
        {
            Password1.SetActive(false);
        }
    }
}
