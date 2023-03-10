using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePassword2 : MonoBehaviour
{
    public GameObject Password2;
    public GameObject DiaryPage4;
    public GameObject DiaryPage6;

    public GameObject RedVersion;
    public GameObject DiaryPage5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DiaryPage4.activeSelf)
        {
            Password2.SetActive(false);

        }

        if (DiaryPage6.activeSelf)
        {
            Password2.SetActive(false);

        }

        if (RedVersion.activeSelf && DiaryPage5.activeSelf)
        {
            Password2.SetActive(true);
        }
        else
        {
            Password2.SetActive(false);
        }
    }
}
