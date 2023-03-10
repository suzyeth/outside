using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExitS2 : MonoBehaviour
{
    public GameObject EnlargedItem;
    


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
        EnlargedItem.SetActive(false);
    }
}
