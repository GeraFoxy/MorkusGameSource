using UnityEngine;

public class lvl1PosRandom : MonoBehaviour
{
    public Transform cookieTransform;

    // Массивы для хранения проверенных координат
    private Vector3[] validPositions = new Vector3[]
    {
        new Vector3(23f, 0.5f, 27f),
        new Vector3(32f, 0.5f, 29f),
        new Vector3(24f, 0.5f, 2f),
        new Vector3(19f, 0.5f, 23f),
        new Vector3(6f, 0.5f, 16f),
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
