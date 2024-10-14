using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������� �� ������������ � ��������
        if (other.CompareTag("Trap"))
        {
            int difficulty = PlayerPrefs.GetInt("Difficulty");

            if (difficulty == 1)
            {
                SceneManager.LoadScene("Defeat"); // ˸���� ��������� - ��� ����
            }
            else if (difficulty == 2)
            {
                SceneManager.LoadScene("Man Menu"); // ������� ��������� - ����� � ������� ����
            }
        }
    }
}
