using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryScript : MonoBehaviour
{
    public GameObject OriginalDiary;
    public GameObject Exit;
    public Collider2D Glasses_Red;
    //public GameObject Exit1;
    

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        OriginalDiary.SetActive(true);
        Exit.SetActive(true);
        //Exit1.SetActive(true);
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
