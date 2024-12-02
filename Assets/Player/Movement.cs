using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // скорость движения игрока


    void Update()

    {

        // Получаем ввод с клавиатуры

        float moveX = Input.GetAxis("Horizontal"); // Движение по оси X (влево/вправо)

        float moveY = Input.GetAxis("Vertical"); // Движение по оси Y (вверх/вниз)


        // Создаем вектор движения

        Vector2 move = new Vector2(moveX, moveY);


        // Перемещаем игрока

        transform.Translate(move * moveSpeed * Time.deltaTime);

    }
}
