using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScene : MonoBehaviour
{
    public GameObject Exit;
    public GameObject BlackSquare;

    
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Exit.activeSelf)
        {
            BlackSquare.SetActive(true);

        }
    }
}
