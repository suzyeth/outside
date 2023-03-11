using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public Animator Start1;
    int Click1 = 0;
    AnimatorStateInfo stateinfo;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Click1 = 1;
        if(Click1 == 1)
        {
            Start1.SetTrigger("Play3Ani");
        }

        //if(Click1 == 2 && Input.GetMouseButtonDown(0))
        {
            //Start1.SetTrigger("Play4Ani");
        }

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateinfo = Start1.GetCurrentAnimatorStateInfo(0);

        if (stateinfo.IsName("3") && stateinfo.normalizedTime >= 0.8f)
        {
            Click1 = 2;

        }

        if(Click1 == 2 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play4Ani");
        }

        if (stateinfo.IsName("4") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 3;
        }

        if (Click1 == 3 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play5Ani");
        }

        if (stateinfo.IsName("5") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 4;
        }

        if (Click1 == 4 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play6Ani");
        }

        if (stateinfo.IsName("6") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 5;
        }

        if (Click1 == 5 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play7Ani");
        }

        if (stateinfo.IsName("7") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 6;
        }

        if (Click1 == 6 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play8Ani");
        }

        if (stateinfo.IsName("8") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 7;
        }

        if (Click1 == 7 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play9Ani");
        }

        if (stateinfo.IsName("9") && stateinfo.normalizedTime >= 0.9f)
        {
            Click1 = 8;
        }

        if (Click1 == 8 && Input.GetMouseButtonDown(0))
        {
            Start1.SetTrigger("Play10Ani");
        }

        if (stateinfo.IsName("10") && stateinfo.normalizedTime >= 0.98f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
