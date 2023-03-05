using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Yellow1 : MonoBehaviour
{
    public GameObject YellowVersion;

    public GameObject BlueVersion;
    public GameObject RedVersion;

    public static float count = 0;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            YellowVersion.SetActive(true);
            count += 1;

            BlueVersion.SetActive(false);
            RedVersion.SetActive(false);
        }
        else
        {
            YellowVersion.SetActive(false);
            count = 0;
        }
    }

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BlueVersion.activeSelf)
        {
            count = 0;
        }
        if(RedVersion.activeSelf)
        {
            count = 0;
        }
    }
}
