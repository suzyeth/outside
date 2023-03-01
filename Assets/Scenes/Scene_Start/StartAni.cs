using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAni : MonoBehaviour
{
    public Animator Start1;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Start1.SetTrigger("Play1Ani");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
