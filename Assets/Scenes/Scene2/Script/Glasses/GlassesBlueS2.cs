using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesBlueS2 : MonoBehaviour
{
    public GameObject BlueVersion;

    public GameObject RedVersion;
    public GameObject YellowVersion;


    public static float count = 0;
    public GameObject PuzzlePieces1;
    public GameObject Room;
    private bool collected=false;

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            BlueVersion.SetActive(true);
            if(Room.activeSelf && collected == false)
            {
            PuzzlePieces1.SetActive(true);
                collected = true;

            }
            


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
        PuzzlePieces1.SetActive(false);
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
