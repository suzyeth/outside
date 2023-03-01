using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary_prop : MonoBehaviour
{
    public GameObject Diary_Scene;
    public GameObject DiaryProp;
    public GameObject Diary_Password;
    public GameObject OriginalDiary;
    public GameObject Exit;

    public GameObject Page1;
    public GameObject Page1RightCollider;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        OriginalDiary.SetActive(true);
        Exit.SetActive(true);
        Page1.SetActive(true);
        Page1RightCollider.SetActive(true);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
