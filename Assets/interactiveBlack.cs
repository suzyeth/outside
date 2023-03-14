using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactiveBlack : MonoBehaviour


{
    public GameObject allstuff;
    public GameObject blacksences;



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
        allstuff.SetActive(false);
        blacksences.SetActive(true);
    }
}
