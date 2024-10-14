using UnityEngine;
using UnityEngine.SceneManagement;

public class Cookie : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // ���������� ���������� �� ����� � �������� � ����� "Cookie"
        if (other.CompareTag("Cookie"))
        {
            // ���������� cookieCount � ������ � ����������
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 2;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie2"))
        {
            // ���������� cookieCount � ������ � ����������
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 3;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie3"))
        {
            // ���������� cookieCount � ������ � ����������
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 4;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie4"))
        {
            // ���������� cookieCount � ������ � ����������
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 5;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie5"))
        {
            SceneManager.LoadScene("WinScene");

            Cursor.visible = true;
        }
    }
}