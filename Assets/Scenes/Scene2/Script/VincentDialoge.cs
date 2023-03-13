using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VincentDialoge : MonoBehaviour
{
    public GameObject DialogeUI;
    public Text DialogeText;
    [TextArea(1, 3)] public string[] DialogeTextList;
    public int currentIndex;

    public GameObject DialogueSystem;
    public GameObject DialoguePanel;
    public GameObject Vincent;
    public GameObject Text_Vincent;
    public GameObject DialogueManager_Vincent;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        currentIndex++;


        if (currentIndex < DialogeTextList.Length)
        {
            DialogeText.text = DialogeTextList[currentIndex];

        }
        else
        {

            Destroy(Text_Vincent, 0f);
            Destroy(DialogueManager_Vincent, 0f);
            Vincent.SetActive(false);
            //DialogueSystem.SetActive(false);
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
