using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    public GameObject DialogeSystem;
    public GameObject DialogeSystem_Doctor;
    public GameObject Dialoge_Doctor;
    

    // Start is called before the first frame update

    private void OnMouseDown()
    {
        DialogeSystem.SetActive(true);
        DialogeSystem_Doctor.SetActive(true);
        Dialoge_Doctor.SetActive(true);
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
