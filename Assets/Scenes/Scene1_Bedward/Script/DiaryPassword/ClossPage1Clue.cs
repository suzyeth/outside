using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClossPage1Clue : MonoBehaviour
{
    public GameObject DiaryPage1_Clue;
    public GameObject DiaryPage2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DiaryPage2.activeSelf)
        {
            DiaryPage1_Clue.SetActive(false);
        }
    }
}
