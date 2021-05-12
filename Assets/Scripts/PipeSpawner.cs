using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;        // ���������� ��� �������� 

    void Start()
    {
        StartCoroutine(Spawner());  // �������� �������� "Spawner" 
    }

    IEnumerator Spawner()           // ������� ���� ��������
    {
        while (true)                // ����������� ���� While - ��������
        {
            yield return new WaitForSeconds(2);     // ���� 2 �������
            float rand = Random.Range(-1f, 4f);     // ��������� ������� �� -1 �� 4 (���� ������� ����)
            GameObject newPipes = Instantiate(Pipes, new Vector3(5, rand, 0), Quaternion.identity);     // ��������� �������������� �� ����� gameObject � ������� ������
            Destroy(newPipes, 10);  // �������� ������ gameObject'a ����� 10 ������ (���� � ������� Pipes - �� ������ � �� ����������)
        }
    }

    // ������������ �� ����� ICE CREAM
    // ����� ���������� - ������ ��� �� ����� ��� � ��������! ��������!
}