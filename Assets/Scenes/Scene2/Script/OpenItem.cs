using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenItem : MonoBehaviour
{
    public GameObject EnlargedItem;
    public GameObject Exit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        EnlargedItem.SetActive(true);
        Exit.SetActive(true);
    }
}
