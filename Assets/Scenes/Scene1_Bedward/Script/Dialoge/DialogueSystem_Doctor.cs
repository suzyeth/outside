using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem_Doctor : MonoBehaviour
{
    public GameObject DialogeUI;
    public Text DialogeText;
    [TextArea(1, 3)] public string[] DialogeTextList;
    public int currentIndex;

    public GameObject DialogueSystem;
    public GameObject DialoguePanel;
    public GameObject Doctor;
    public GameObject Text_Doctor;
    public GameObject DialogueManager_Doctor;
    public GameObject TurnRight;
 
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        currentIndex++;
        
        if(Doctor.activeSelf)
        {
            if (currentIndex < DialogeTextList.Length)
            {
                DialogeText.text = DialogeTextList[currentIndex];

            }
            else
            {
                Destroy(Text_Doctor, 0f);
                Destroy(DialogueManager_Doctor, 0f);
                Doctor.SetActive(false);
                //DialogueSystem.SetActive(false);
                DialoguePanel.SetActive(false);
                TurnRight.SetActive(true);

            }
        }
            
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
