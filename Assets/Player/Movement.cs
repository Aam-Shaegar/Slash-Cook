using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �������� ������


    void Update()

    {

        // �������� ���� � ����������

        float moveX = Input.GetAxis("Horizontal"); // �������� �� ��� X (�����/������)

        float moveY = Input.GetAxis("Vertical"); // �������� �� ��� Y (�����/����)


        // ������� ������ ��������

        Vector2 move = new Vector2(moveX, moveY);


        // ���������� ������

        transform.Translate(move * moveSpeed * Time.deltaTime);

    }
}
