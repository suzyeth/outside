using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem_new : MonoBehaviour
{
    [Header("UI")]
    public Text textLabel;
    public GameObject Log;

    [Header("words")]
    public TextAsset textfile; 
    public int index;
    public float textSpeed = 0.05f;

    bool textFinished;
    List<string> textList = new List<string>();

    [Header("Gameobject")]
    public GameObject Nurse;
    public GameObject Doctor;
    public GameObject DialogueSystem;

    // Start is called before the first frame update

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";
        switch (textList[index])
        {
            case "Nurse\r":
                {
                    //Nurse.SetActive(true); 
                    index++; 
                    break;
                }
            
            case "Doctor\r": 
                {

                    index++;
                    break;
                }
        }
        for (int i = 0; i < textList[index].Length; i++)
      
        {
            textLabel.text += textList[index][i]; 
            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true; 
        index++; 

    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textSpeed = 0.05f; 
        if (Input.GetKeyDown(KeyCode.Mouse0) && index == textList.Count)
        {
            DialogueSystem.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && textFinished)
        {
            StartCoroutine(SetTextUI());
        }
    }
}
