using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klotski : MonoBehaviour

  
{
    private Rigidbody2D rb;
    private Vector3 mousePosition;
    private Vector3 objectPosition;
    private float distance;// 声明一个浮点数变量，用于记录鼠标与物体的距离
    private bool isDragging;
    private bool isOnBoard;

    public GameObject Puzzle;
    public Transform Board;

    public string boardTagIs;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isOnBoard = false;
    }

    void Update()
    {
        




            if (Input.GetMouseButtonDown(0) && isOnBoard == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            // 如果碰撞到了物体
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // 开始拖拽物体
                isDragging = true;
                rb.isKinematic = true;
                // 设置物体为运动学物体，以便拖拽
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // 记录鼠标位置
                objectPosition = transform.position - mousePosition;
                // 记录物体位置
                distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                // 记录鼠标与物体的距离
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            rb.isKinematic = false;
        }

        if (isDragging)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + objectPosition.x, mousePosition.y + objectPosition.y, distance);
        }

        

    }


    private void OnTriggerEnter2D(Collider2D coll)
    {
        print("Col with " + coll.gameObject.name);
        print("Tag with " + coll.gameObject.tag);

        if (coll.gameObject.tag == boardTagIs)
        {
            Debug.Log("x");
            Puzzle.transform.position = Board.transform.position;
            isDragging = false;
            isOnBoard = true;
            
           

            
        }

        
        



    }

}





