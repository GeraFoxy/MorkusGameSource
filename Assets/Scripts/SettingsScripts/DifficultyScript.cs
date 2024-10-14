using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    void Start()
    {
        // Проверяем, есть ли сохранённое значение сложности, если нет, ставим "лёгкую" (1)
        if (!PlayerPrefs.HasKey("Difficulty"))
        {
            PlayerPrefs.SetInt("Difficulty", 1);
            PlayerPrefs.Save();
        }
    }

    public void HardDifficulty()
    {
        PlayerPrefs.SetInt("Difficulty", 2); // 2 - сложная сложность
        PlayerPrefs.Save();
    }

    public void EasyDifficulty()
    {
        PlayerPrefs.SetInt("Difficulty", 1); // 1 - лёгкая сложность
        PlayerPrefs.Save();
    }

    public void ButtonToMenu()
    {
        SceneManager.LoadScene("Man Menu");
    }
}

