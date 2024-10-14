using UnityEngine;

public class CameraWay : MonoBehaviour
{
    public Transform playerTransform;  // Трансформ игрока
    public Vector3 offset;  // Смещение камеры

    [SerializeField] private float mouseSensitivity = 1000f;

    private float rotationY = 0f;  // Вращение по оси Y (для игрока и камеры)
    private float rotationX = 0f;  // Вращение по оси X (для камеры)

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Обновляем вращение по оси Y и X
        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -30f, 30f);

        // Поворот игрока только по оси Y (вращение по горизонтали)
        playerTransform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        // Поворот камеры по осям X (наклон) и Y (горизонтальное вращение)
        Quaternion cameraRotation = Quaternion.Euler(rotationX, rotationY, 0f);
        transform.position = playerTransform.position + cameraRotation * offset;  // Перемещение камеры

        // БЛЯДСКАЯ КАМЕРА СМОТРИТ ТОЛЬКО НА ИГРОКА !! ВАЖНО !!
        transform.LookAt(playerTransform.position + Vector3.up * offset.y);
    }
}

