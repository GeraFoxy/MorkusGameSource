using UnityEngine;
using UnityEngine.SceneManagement;

public class Cookie : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // ПроверОЧКА столкнулся ли игрок с объектом с тегом "Cookie"
        if (other.CompareTag("Cookie"))
        {
            // Увеличение cookieCount и запись в плеерпрефс
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 2;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie2"))
        {
            // Увеличение cookieCount и запись в плеерпрефс
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 3;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie3"))
        {
            // Увеличение cookieCount и запись в плеерпрефс
            int cookieCount = PlayerPrefs.GetInt("cookieCount");
            cookieCount = 4;
            PlayerPrefs.SetInt("cookieCount", cookieCount);
            PlayerPrefs.Save();

            SceneManager.LoadScene("Levels Map");

            Cursor.visible = true;
        }

        if (other.CompareTag("Cookie4"))
        {
            // Увеличение cookieCount и запись в плеерпрефс
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