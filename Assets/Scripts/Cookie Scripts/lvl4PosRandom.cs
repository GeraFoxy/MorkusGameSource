using UnityEngine;

public class lvl4PosRandom : MonoBehaviour
{
    public Transform cookieTransform;

    // Массивы для хранения проверенных координат
    private Vector3[] validPositions = new Vector3[]
    {
        new Vector3(3f, 1.5f, 5f),
        new Vector3(66f, 1.5f, 64f),
        new Vector3(66f, 1.5f, 52f),
        new Vector3(66f, 1.5f, 4f),
        new Vector3(66f, 1.5f, 30f),
        new Vector3(40f, 1.5f, 18f),
        new Vector3(33f, 1.5f, 9f),
        new Vector3(47f, 1.5f, 34f),
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
