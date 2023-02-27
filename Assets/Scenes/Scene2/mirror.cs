using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirror : MonoBehaviour
{
    
    float n=1;

    public GameObject Mirror;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        //transform.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - n);//
        Mirror.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
