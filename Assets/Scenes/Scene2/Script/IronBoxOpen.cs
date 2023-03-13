using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class IronBoxOpen : MonoBehaviour
{
    public GameObject BoxItem;
    public GameObject KeyInventory;
    public GameObject BoxInventory;

    public GameObject BoxProp;
    public GameObject BoxInScene;

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
            KeyInventory.SetActive(false);
            BoxInventory.SetActive(true);
        }


        BoxProp.SetActive(true);
        BoxInScene.SetActive(false);

    }


}
