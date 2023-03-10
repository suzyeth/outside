using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseHistory : MonoBehaviour
{
    public GameObject Casehistory;
    public GameObject Detcet;
    public GameObject Inventory;
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
        Detcet.SetActive(false);
        Casehistory.SetActive(true);
        Inventory.SetActive(true);
    }
}
