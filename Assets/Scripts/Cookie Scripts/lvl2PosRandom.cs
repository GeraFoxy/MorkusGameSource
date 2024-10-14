using UnityEngine;

public class lvl2PosRandom : MonoBehaviour
{
    public Transform cookieTransform;

    // Массивы для хранения проверенных координат
    private Vector3[] validPositions = new Vector3[]
    {
        new Vector3(1f, 1.5f, 8f),
        new Vector3(45f, 1.5f, 47f),
        new Vector3(24f, 1.5f, 46f),
        new Vector3(46f, 1.5f, 8f),
        new Vector3(29f, 1.5f, 25f),
        new Vector3(31f, 1.5f, 49f),
        new Vector3(24f, 1.5f, 26f),
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
