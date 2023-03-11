using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    
    float n=10;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        n = n - 1;
        transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, n/10);
        /*Mirror.SetActive(false);*/

       
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
