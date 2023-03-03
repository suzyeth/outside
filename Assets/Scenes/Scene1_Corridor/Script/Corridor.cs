using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Corridor : MonoBehaviour
{
    public List<GameObject> Corridors = new List<GameObject>();
    int i=0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseEnter()
    {






    }

    private void OnMouseDown()
    {
        i = i + 1;
        
                Corridors[i].SetActive(true);
                Corridors[i].SetActive(true);








    }
}
