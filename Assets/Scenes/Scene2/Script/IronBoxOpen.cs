using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class IronBoxOpen : MonoBehaviour
{
    public GameObject BoxItem;
    public GameObject BoxItemopened;
    public GameObject KeyInventory;
   

   
    

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
        if(KeyInventory.activeSelf)
        {
            BoxItem.SetActive(false);
            BoxItemopened.SetActive(true);
            KeyInventory.SetActive(false);
            
        }

        

    }


}
