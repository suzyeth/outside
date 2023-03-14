using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)|| Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Resart();
        }

    }

    public void Resart()
    {

        SceneManager.LoadScene(0);

    }

    public void Close()
    {
        Application.Quit();//ÍË³öÓ¦ÓÃ
        //UnityEditor.EditorApplication.isPlaying = false;
    }



}
