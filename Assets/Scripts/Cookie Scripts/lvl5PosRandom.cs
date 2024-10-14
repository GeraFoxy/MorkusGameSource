using UnityEngine;

public class lvl5PosRandom : MonoBehaviour
{
    public Transform cookieTransform;

    // Массивы для хранения проверенных координат
    private Vector3[] validPositions = new Vector3[]
    {
        new Vector3(2f, 1.5f, 6f),
        new Vector3(97f, 1.5f, 1f),
        new Vector3(97f, 1.5f, 91f),
        new Vector3(11f, 1.5f, 95f),
        new Vector3(6f, 1.5f, 48f),
        new Vector3(98f, 1.5f, 53f),
        new Vector3(73f, 1.5f, 63f),
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
