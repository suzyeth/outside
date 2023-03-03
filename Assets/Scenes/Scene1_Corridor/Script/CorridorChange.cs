using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorChange : MonoBehaviour
{

    public List<GameObject> Corridors = new List<GameObject>();
    int i = 0;
    int j = 1;
    int k = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 2)
        {
            i = 0;
        }
        if (j == 2)
        {
            j = 0;
        }
        if (k == 2)
        {
            k = 0;
        }



    }

    private void OnMouseDown()
    {
        i =i+1;
        j =j+1;
        k =k+1;

        Corridors[i].SetActive(true);
        Corridors[j].SetActive(false);
        Corridors[k].SetActive(false);
    }



}
