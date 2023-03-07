using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class box : MonoBehaviour
{
    public List<GameObject> boxs = new List<GameObject>();
    int index ;
    bool boxopened=false;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        if(boxopened ==false)
        {
            Changebox(1);
        }
        
    }


    public void Changebox(int direction)
    {
        index = index += direction;
        index = Math.Clamp(index, 0, boxs.Count - 1);

        for (i = 0; i < boxs.Count; i++)
        {
            boxs[i].SetActive(i == index);

            if (index == 3)
            {
                boxopened = true;
            }
            Debug.Log(index);
        }
        
        
    }

}
