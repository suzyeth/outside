using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CorridorChange : MonoBehaviour
{

    public List<GameObject> Corridors = new List<GameObject>();
    public GameObject leftbutton;
    public GameObject rightbutton;
    int index= 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (index == Corridors.Count - 1)
        {
            rightbutton.SetActive(false);
        }
        else 
        {
            rightbutton.SetActive(true);
        }

        if (index == 0)
        {
            leftbutton.SetActive(false);
        }
        else
        {
            leftbutton.SetActive(true);
        }*/

    }

    private void OnMouseDown()
    {
        movePage(1);
        


    }

    public void movePage(int direction)
    {
        index = index += direction;
        index = Math.Clamp(index, 0, Corridors.Count-1);
        Debug.Log("index" + index);

        for (int i = 0; i < Corridors.Count; i++)
        {
            Corridors[i].SetActive(i == index);
        }
    }

    



}
