using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CorridorChange : MonoBehaviour
{

    public List<GameObject> Corridors = new List<GameObject>();
    
    int index;

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
        movePage(1);
    }

    public void movePage(int direction)
    {
        index = index += direction;
        index = Math.Clamp(index, 0, Corridors.Count-1);

        for (int i = 0; i < Corridors.Count; i++)
        {
            Corridors[i].SetActive(i == index);
        }
    }

    



}
