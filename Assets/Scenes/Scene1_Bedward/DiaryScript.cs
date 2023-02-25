using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryScript : MonoBehaviour
{
    public GameObject OriginalDiary;
    public GameObject Exit;
    public Collider2D Glasses_Red;
    public GameObject Diary_prop;
    public GameObject Diary_prop1;
    public GameObject Diary_Scene;
    public GameObject Phone_prop1;
    //public GameObject Exit1;
    

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        OriginalDiary.SetActive(true);
        Exit.SetActive(true);
      
        Diary_Scene.SetActive(false);

        if(Phone_prop1.activeSelf == false)
        {
            Diary_prop.SetActive(true);
            
        }

        if (Phone_prop1.activeSelf)
        {
            
            Diary_prop1.SetActive(true);
        }

    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
