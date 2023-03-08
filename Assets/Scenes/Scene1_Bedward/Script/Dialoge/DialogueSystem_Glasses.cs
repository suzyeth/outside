using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem_Glasses : MonoBehaviour
{
    public GameObject DialogeUI;
    public Text DialogeText;
    [TextArea(1, 3)] public string[] DialogeTextList;
    public int currentIndex;

    public GameObject DialogueSystem;
    public GameObject DialoguePanel;
    public GameObject Text_Glasses;
    public GameObject DialogueManage_Glasses;
    public GameObject Test;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        currentIndex++;


        if (currentIndex < DialogeTextList.Length)
        {
            DialogeText.text = DialogeTextList[currentIndex];
            Test.SetActive(true);
        }
        else
        {
            Destroy(Text_Glasses, 0f);
            Destroy(DialogueManage_Glasses, 0f);
            DialoguePanel.SetActive(false);

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
