using UnityEngine;

public class lvl3PosRandom : MonoBehaviour
{
    public Transform cookieTransform;

    // Массивы для хранения проверенных координат
    private Vector3[] validPositions = new Vector3[]
    {
        new Vector3(71f, 1.5f, 6f),
        new Vector3(73f, 1.5f, 40f),
        new Vector3(64f, 1.5f, 72f),
        new Vector3(47f, 1.5f, 69f),
        new Vector3(1f, 1.5f, 72f),
        new Vector3(5f, 1.5f, 41f),
        new Vector3(6f, 1.5f, 19f),
        new Vector3(49f, 1.5f, 7f),
        new Vector3(13f, 1.5f, 67f),
        new Vector3(31f, 1.5f, 59f),
        new Vector3(24f, 1.5f, 31f),
    };

    private Vector3 currentCookiePosition;

    void Start()
    {
        int index = Random.Range(0, validPositions.Length);

        // Определение позиции печеньки, используя выбранные координаты
        currentCookiePosition = validPositions[index];

        cookieTransform.transform.position = currentCookiePosition;
    }
}
