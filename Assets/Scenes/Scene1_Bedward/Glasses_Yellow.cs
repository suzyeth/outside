using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_Yellow : MonoBehaviour
{

    public GameObject YellowVersion;
    public GameObject Exit;

    public GameObject BlueVersion;
    public GameObject RedVersion;

    public GameObject DiaryPage4;
    public GameObject Password2;
    // Start is called before the first frame update

    private void OnMouseDown()
    {

        YellowVersion.SetActive(true);
        Exit.SetActive(true);


        if (BlueVersion.activeSelf)
        {
            BlueVersion.SetActive(false);

        }

        if (RedVersion.activeSelf)
        {
            RedVersion.SetActive(false);

        }

        if (DiaryPage4.activeSelf)
        {
            Password2.SetActive(true);
        }
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
