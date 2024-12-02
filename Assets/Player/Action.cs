using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameObject textPrefab; // ������ ������

    public Transform player; // ������ �� ������ ������


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 - ��� ���
        {
            SpawnText();
        }
    }


    void SpawnText()
    {
        // �������� ������� ������
        Vector2 spawnPosition = player.position;
        // ������� ����� �����
        GameObject textInstance = Instantiate(textPrefab, spawnPosition, Quaternion.identity);
        // ��������� ������
        // ������: ���� �� ����������� TextMeshPro
        var textMeshPro = textInstance.GetComponent<TMPro.TextMeshProUGUI>(); // ���������, ��� � ��� ���� TMPro
        if (textMeshPro != null)
        {
            textMeshPro.text = "��� �����"; // �������� �� ����������� �����
        }
        // ����� �������� ������ ��� ����������� ������ ����� ��������� �����
        Destroy(textInstance, 2f); // �������� ������ ����� 2 ������� (�� �������)
    }
}
