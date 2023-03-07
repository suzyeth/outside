using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeSuccess : MonoBehaviour
{
    public GameObject Puzzle1;
    public Transform Board1;
    public GameObject Puzzle2;
    public Transform Board2; 
    public GameObject Puzzle3;
    public Transform Board3;
    public GameObject Realhistory;
    public GameObject Jigsaw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Puzzle1.transform.position == Board1.transform.position && Puzzle2.transform.position == Board2.transform.position && Puzzle3.transform.position == Board3.transform.position)
        {
            Realhistory.SetActive(true);
            Jigsaw.SetActive(false);
        }
    }
}
