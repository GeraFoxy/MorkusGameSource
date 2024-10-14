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
                SceneManager.LoadScene("Defeat"); // ˸���� ��������� - ��� ����
            }
            else if (difficulty == 2)
            {
                SceneManager.LoadScene("Man Menu"); // ������� ��������� - ����� � ������� ����
            }
        }
    }

    public float GetRemainingTime()
    {
        return timeRemaining;
    }
}

