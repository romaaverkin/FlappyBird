using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;                                 // ���������� ��� ���� ������
    Rigidbody2D BirdRigid;                              // ��� ����� Rigidbody, � �� ������ �� ����� �������

    //public GameObject RestartButton;                    // ��� ��� ������

    void Start()
    {
        Time.timeScale = 1;                             //  �������� ����� 1 - �.�. ��� ���� ��������
        BirdRigid = GetComponent<Rigidbody2D>();        //  �������� ��������� Rigidbody
    }


    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))     // ���� ���� �� ������ ���� ��� �����
        {
            BirdRigid.velocity = Vector2.up * force;    // ��� ��� ���� �����������
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)  // ��������� ������������
    {
        if (collision.collider.tag == "Enemy")          // ���� ��� ������� "Enemy"
        {
            Destroy(gameObject);                        // �� ������ �����������(
            Time.timeScale = 0;                         // ����� ���������������
            //RestartButton.SetActive(true);              // ������ �������� ����������
        }
    }

    // ������������ �� ����� ICE CREAM
    // ����� ���������� - ������ ��� �� ����� ��� � ��������! ��������!
}
