using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_prop : MonoBehaviour
{
    public GameObject Glasses_UI;
    public GameObject Glasses_prop1;

    public GameObject DialogePanel;
    public GameObject Text_Glasses;
    public GameObject DialogeSystem_Glasses;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Glasses_UI.SetActive(true);
        Glasses_prop1.SetActive(false);

        //DialogePanel.SetActive(true);
        //DialogeSystem_Glasses.SetActive(true);
        //Text_Glasses.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
