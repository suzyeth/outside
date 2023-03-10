using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLabCorridorSymbol : MonoBehaviour
{
    public GameObject BlueVersion;
    public GameObject LabCorridor;
    public GameObject Symbol1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BlueVersion.activeSelf && LabCorridor.activeSelf)
        {
            Symbol1.SetActive(true);
        }
        else
        {
            Symbol1.SetActive(false);
        }
    }
}
