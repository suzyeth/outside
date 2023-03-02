using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_StartScript : MonoBehaviour
{
    public Animator StartAnimator;
    AnimatorStateInfo stateinfo;

    public Animator Start1;
    private void OnMouseDown()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
