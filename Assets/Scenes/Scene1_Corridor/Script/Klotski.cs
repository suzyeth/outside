using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klotski : MonoBehaviour

  
{
    private Rigidbody2D rb;
    private Vector3 mousePosition;
    private Vector3 objectPosition;
    private float distance;// ����һ�����������������ڼ�¼���������ľ���
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
            // �����ײ��������
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // ��ʼ��ק����
                isDragging = true;
                rb.isKinematic = true;
                // ��������Ϊ�˶�ѧ���壬�Ա���ק
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                // ��¼���λ��
                objectPosition = transform.position - mousePosition;
                // ��¼����λ��
                distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                // ��¼���������ľ���
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





