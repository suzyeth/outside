using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCase : MonoBehaviour
{
    public GameObject CaseHistory;
    public GameObject Case_Page1;

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        CaseHistory.SetActive(true);
        Case_Page1.SetActive(true);

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
