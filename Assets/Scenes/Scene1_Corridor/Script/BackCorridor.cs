using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCorridor : MonoBehaviour
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
        Room.SetActive(false);
        Door.SetActive(true);
        ToLeft.SetActive(true);
        ToRight.SetActive(true);
    }


}
