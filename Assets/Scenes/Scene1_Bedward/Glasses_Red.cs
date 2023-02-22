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

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (OriginalDiary.activeSelf)
        {
            Diary_Password.SetActive(true);
            OriginalDiary.SetActive(false);
            Phone1.SetActive(true);

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
        
    }
}
