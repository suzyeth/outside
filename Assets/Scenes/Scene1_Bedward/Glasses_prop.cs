using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses_prop : MonoBehaviour
{
    public GameObject Glasses_UI;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Glasses_UI.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
