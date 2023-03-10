using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_StartScript : MonoBehaviour
{
    public Animator StartAnimator;
    AnimatorStateInfo stateinfo;
    public GameObject Click;
    public Animator Start1;
    public GameObject Black1;


    private void OnMouseDown()
    {
        Click.SetActive(true);
        
        Start1.SetTrigger("Play1Ani");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateinfo = StartAnimator.GetCurrentAnimatorStateInfo(0);

        if (stateinfo.IsName("1") && stateinfo.normalizedTime >= 1.0f)
        {
            Black1.SetActive(true);
            Start1.SetTrigger("Play2Ani");
            
        }

        //if (stateinfo.IsName("2") && stateinfo.normalizedTime >= 1.0f)
        {
            
        }
    }
}
