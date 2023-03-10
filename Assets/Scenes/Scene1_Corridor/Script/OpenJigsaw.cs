using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJigsaw : MonoBehaviour
{
    public GameObject PuzzleProp3;
    public GameObject Jigsaw;
    public GameObject Box;
    public GameObject Cabinet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleProp3.activeSelf)
        {
            Jigsaw.SetActive(true);
            Box.SetActive(false);
            Cabinet.SetActive(false);
        }

        

    }
}
