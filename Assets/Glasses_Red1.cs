using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Red1 : MonoBehaviour
{
    public GameObject RedVersion;

    public GameObject YellowVersion;
    public GameObject BlueVersion;

    public static float count = 0;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            RedVersion.SetActive(true);
            count = 1;

            YellowVersion.SetActive(false);
            BlueVersion.SetActive(false);
        }
        else
        {
            RedVersion.SetActive(false);
            count = 0;
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (YellowVersion.activeSelf)
        {
            count = 0;
        }
        if (BlueVersion.activeSelf)
        {
            count = 0;
        }
    }
}
