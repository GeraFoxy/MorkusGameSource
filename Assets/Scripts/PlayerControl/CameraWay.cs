using UnityEngine;

public class CameraWay : MonoBehaviour
{
    public Transform playerTransform;  // ��������� ������
    public Vector3 offset;  // �������� ������

    [SerializeField] private float mouseSensitivity = 1000f;

    private float rotationY = 0f;  // �������� �� ��� Y (��� ������ � ������)
    private float rotationX = 0f;  // �������� �� ��� X (��� ������)

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ��������� �������� �� ��� Y � X
        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -30f, 30f);

        // ������� ������ ������ �� ��� Y (�������� �� �����������)
        playerTransform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        // ������� ������ �� ���� X (������) � Y (�������������� ��������)
        Quaternion cameraRotation = Quaternion.Euler(rotationX, rotationY, 0f);
        transform.position = playerTransform.position + cameraRotation * offset;  // ����������� ������

        // �������� ������ ������� ������ �� ������ !! ����� !!
        transform.LookAt(playerTransform.position + Vector3.up * offset.y);
    }
}

