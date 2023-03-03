using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorsChangeLeft : MonoBehaviour
{
    public List<GameObject> Corridors = new List<GameObject>();
 

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        FindObjectOfType<CorridorChange>().movePage(-1);


    }

  

    



}