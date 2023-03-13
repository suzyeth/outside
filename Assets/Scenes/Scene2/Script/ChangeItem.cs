using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeItem : MonoBehaviour
{
    public GameObject ItemInventory;
    public GameObject NewItemInventory;
    private bool active=false;
    // Start is called before the first frame update
    void Start()
    {
        ItemInventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemInventory.activeSelf)
        {
            active = true;
            ItemInventory.SetActive(false);
            ItemInventory.SetActive(true);
        }
    }
}
