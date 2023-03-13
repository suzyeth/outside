using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealhistoryInventory : MonoBehaviour
{
    public GameObject Puzzle;
    
    public GameObject Detect;
    public GameObject Puzzle1;
    public GameObject Puzzle2;
    public GameObject Puzzle3;
    //∆¥ÕºÀÈ∆¨ºÏ≤‚
    public GameObject Detect1;
    public GameObject Detect2;
    public GameObject Detect3;
    int n;

    public List<GameObject> PuzzlesProps = new List<GameObject>();
    int index;

    int i = 0;

    


    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Puzzle.SetActive(false);
        
        Detect.SetActive(true);
        Countnumber();

        Puzzle.SetActive(false);

        if (Puzzle1.activeSelf)
        {
            Puzzle2.SetActive(true);
            Puzzle1.SetActive(false);
        }
        else if (Puzzle2.activeSelf)
        {
            Puzzle3.SetActive(true);
            Puzzle2.SetActive(false);
        }
        else
        {
            Puzzle1.SetActive(true);
        }


    }



    public void Countnumber()
    {
        if (Detect1.activeSelf)
        {

            n = n + 1;
            
           
            Debug.Log("Dn1=" + n);
        }

        if (Detect2.activeSelf )
        {

            n = n + 1;


            Debug.Log("Dn2=" + n);
        }

        if (Detect3.activeSelf)
        {

            n = n + 1;


            Debug.Log("Dn3=" + n);
        }


        Debug.Log("n="+n);
        index = index + n -1;
        index = Math.Clamp(index, 0, PuzzlesProps.Count - 1);
        
        for (i = 0; i < PuzzlesProps.Count ; i++)
        {
            PuzzlesProps[i].SetActive(i == index);
            Debug.Log(index);

        }
    }
}
