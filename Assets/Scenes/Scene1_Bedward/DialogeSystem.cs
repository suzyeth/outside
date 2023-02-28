using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeSystem : MonoBehaviour
{
    public GameObject DialogeUI;
    public Text DialogeText;
    [TextArea(1, 3)] public string[] DialogeTextList;
    public int currentIndex;

    public GameObject DialogueSystem;
    public GameObject Nurse;

    [Header("word")]
    public TextAsset textfile;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        currentIndex++;

        if(currentIndex < DialogeTextList.Length)
        {
            DialogeText.text = DialogeTextList[currentIndex];

        }
        else
        {
            DialogueSystem.SetActive(false);
            Nurse.SetActive(false);
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
