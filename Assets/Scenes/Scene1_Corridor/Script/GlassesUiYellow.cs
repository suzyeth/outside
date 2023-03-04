using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesUiYellow : MonoBehaviour
{
    public GameObject BlueVersion;
    public GameObject RedVersion;
    public GameObject YellowVersion;



    






    // Start is called before the first frame update
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        YellowVersion.SetActive(true);
        Debug.Log("y");

        if (RedVersion.activeSelf)
        {
            RedVersion.SetActive(false);

        }

        if (BlueVersion.activeSelf)
        {
            BlueVersion.SetActive(false);

        }



        //if (OriginalDiary.activeSelf)
        {

            //OriginalDiary.SetActive(false);
        }

        //if(Red.activeSelf)
        {
            //Purple.SetActive(true);
        }

        //Blue.SetActive(true);
    }

    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {

    }
}
