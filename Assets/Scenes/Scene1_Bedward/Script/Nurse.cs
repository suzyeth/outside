using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : MonoBehaviour
{
    public GameObject DialogePanel;
    public GameObject Dialogue_Nurse;
    // Start is called before the first frame update
    void Start()
    {
        DialogePanel.SetActive(true);
        Dialogue_Nurse.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
