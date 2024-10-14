using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    private float timeRemaining;
    [SerializeField] private float levelTime = 180f;

    void Start()
    {

        timeRemaining = levelTime;
    }

    private void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            int difficulty = PlayerPrefs.GetInt("Difficulty");

            if (difficulty == 1)
            {
                SceneManager.LoadScene("Defeat"); // Лёгкая сложность - даю шанс
            }
            else if (difficulty == 2)
            {
                SceneManager.LoadScene("Man Menu"); // Сложная сложность - сразу в главное меню
            }
        }
    }

    public float GetRemainingTime()
    {
        return timeRemaining;
    }
}

