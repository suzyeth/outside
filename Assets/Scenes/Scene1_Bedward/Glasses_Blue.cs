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
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (OriginalDiary.activeSelf)
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
