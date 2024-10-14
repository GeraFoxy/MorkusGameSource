using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    void Start()
    {
        // ���������, ���� �� ���������� �������� ���������, ���� ���, ������ "�����" (1)
        if (!PlayerPrefs.HasKey("Difficulty"))
        {
            PlayerPrefs.SetInt("Difficulty", 1);
            PlayerPrefs.Save();
        }
    }

    public void HardDifficulty()
    {
        PlayerPrefs.SetInt("Difficulty", 2); // 2 - ������� ���������
        PlayerPrefs.Save();
    }

    public void EasyDifficulty()
    {
        PlayerPrefs.SetInt("Difficulty", 1); // 1 - ����� ���������
        PlayerPrefs.Save();
    }

    public void ButtonToMenu()
    {
        SceneManager.LoadScene("Man Menu");
    }
}

