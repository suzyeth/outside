using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesUiBlue : MonoBehaviour
{
    
    

    public GameObject BlueVersion;
    public GameObject RedVersion;
    public GameObject YellowVersion;
    
    
    
    public GameObject Symbol;

    
    

    

    // Start is called before the first frame update
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        BlueVersion.SetActive(true);
        Debug.Log("z");

        if (RedVersion.activeSelf)
        {
            RedVersion.SetActive(false);

        }

        if (YellowVersion.activeSelf)
        {
            YellowVersion.SetActive(false);

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
        Symbol.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {

    }
}






    

    


