using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject Door;
    public GameObject Room;
    public GameObject ToLeft;
    public GameObject ToRight;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Room.SetActive(true);
        Door.SetActive(false);
        ToLeft.SetActive(false);
        ToRight.SetActive(false);
    }


}
