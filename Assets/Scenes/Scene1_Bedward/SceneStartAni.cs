using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStartAni : MonoBehaviour
{
    public Animator StartAni;
    AnimatorStateInfo stateInfo;

    public GameObject DialogeSystem1;
    public GameObject StartAnimation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stateInfo = StartAni.GetCurrentAnimatorStateInfo(0);
        
        if(stateInfo.IsName("Start") && stateInfo.normalizedTime >= 1.0f)
        {
            DialogeSystem1.SetActive(true);
            StartAnimation.SetActive(false);
        }
    }
}
