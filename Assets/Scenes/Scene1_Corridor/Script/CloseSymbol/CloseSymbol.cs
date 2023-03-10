using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSymbol : MonoBehaviour

{
    public GameObject BlueVersion;
    public GameObject Map;
    public GameObject Symbol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (BlueVersion.activeSelf && Map.activeSelf)
        {
            Symbol.SetActive(true);
        }
        else
        {
            Symbol.SetActive(false);
        }
    }
}
