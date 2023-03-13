using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesYellowS2 : MonoBehaviour
{
    
    public GameObject YellowVersion;
    
    public GameObject BlueVersion;
    public GameObject RedVersion;

    public GameObject Room;

    public static float count = 0;
    public GameObject PuzzlePieces1;
    private bool collected = false;


    // Start is called before the first frame update

    private void OnMouseDown()
    {
        if (count == 0)
        {
            YellowVersion.SetActive(true);

            if (Room.activeSelf && collected == false)
            { PuzzlePieces1.SetActive(true);
                collected = true;
            }

                count = 1;

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
        PuzzlePieces1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (BlueVersion.activeSelf)
        {
            count = 0;
        }
        if (RedVersion.activeSelf)
        {
            count = 0;
        }
    }
}
