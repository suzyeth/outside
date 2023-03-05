using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Blue1 : MonoBehaviour
{
    public GameObject BlueVersion;

    public GameObject YellowVersion;
    public GameObject RedVersion;

    public static float count = 0;
   

    
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if(count == 0)
        {
            BlueVersion.SetActive(true);
            count = 1;

            YellowVersion.SetActive(false);
            RedVersion.SetActive(false);
        }
        else
        {
            BlueVersion.SetActive(false);
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
        if (RedVersion.activeSelf)
        {
            count = 0;
        }
    }
}
