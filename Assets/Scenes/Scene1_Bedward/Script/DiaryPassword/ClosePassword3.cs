using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePassword3 : MonoBehaviour
{
    public GameObject Password3;
    public GameObject DiaryPage5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DiaryPage5.activeSelf)
        {
            Password3.SetActive(false);

        }

    }
}
