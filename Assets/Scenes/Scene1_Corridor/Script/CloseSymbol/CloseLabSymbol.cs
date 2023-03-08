using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLabSymbol : MonoBehaviour
{
    public GameObject BlueVersion;
    public GameObject Lab;
    public GameObject Symbol1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (BlueVersion.activeSelf && Lab.activeSelf)
        {
            Symbol1.SetActive(true);
        }
        else
        {
            Symbol1.SetActive(false);
        }
    }
}
