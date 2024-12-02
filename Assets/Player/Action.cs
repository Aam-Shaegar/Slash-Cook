using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public GameObject textPrefab; // Префаб текста

    public Transform player; // Ссылка на объект игрока


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 - это ЛКМ
        {
            SpawnText();
        }
    }


    void SpawnText()
    {
        // Получаем позицию игрока
        Vector2 spawnPosition = player.position;
        // Создаем новый текст
        GameObject textInstance = Instantiate(textPrefab, spawnPosition, Quaternion.identity);
        // Настройка текста
        // Пример: если вы используете TextMeshPro
        var textMeshPro = textInstance.GetComponent<TMPro.TextMeshProUGUI>(); // Убедитесь, что у вас есть TMPro
        if (textMeshPro != null)
        {
            textMeshPro.text = "Ваш текст"; // Замените на необходимый текст
        }
        // Можно добавить логику для уничтожения текста через некоторое время
        Destroy(textInstance, 2f); // Удаление текста через 2 секунды (по желанию)
    }
}
