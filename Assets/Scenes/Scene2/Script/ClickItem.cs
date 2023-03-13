using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{
    public GameObject ItemDisappear;
    public GameObject ItemAppear;

    public GameObject AlbumInScene;
    public GameObject AlbumProp;
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
        ItemAppear.SetActive(true);
        ItemDisappear.SetActive(false);

        AlbumInScene.SetActive(false);
        AlbumProp.SetActive(true);
    }
}