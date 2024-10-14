using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button defeatButton;      // ������ ������ �� ����� Defeat
    public Text timeText;            // ����� ��� ����������� �������

    private TimerScript timerScript; // ������ �� ������

    private bool isPaused = false;
    private int languageFlag;
    void Start()
    {
        // ���������� ������ �����
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // ������� ��������� TimerScript
        timerScript = Object.FindFirstObjectByType<TimerScript>();

        languageFlag = PlayerPrefs.GetInt("Language");
    }

    void Update()
    {
        // ��������� ������� ������� Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }


        if (languageFlag == 1)
        {
            timeText.text = "Time left: " + timerScript.GetRemainingTime().ToString("F2") + "s";
        }
        else if (languageFlag == 2)
        {
            timeText.text = "�����: " + timerScript.GetRemainingTime().ToString("F2") + "c";

        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        // ���������� �������
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None; // �������������� ������
            Cursor.visible = true; // ������� ������ �������
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // ������������� ������
            Cursor.visible = false; // ������� ������ ���������
        }
    }

    public void OnDefeatButtonClicked()
    {
        // ������ ���������� ������� ����� ��������� �� �����
        Cursor.visible = true; // ���������� ������ ����� ��������� �� �����
        Cursor.lockState = CursorLockMode.None; // �������������� ������
        Time.timeScale = 1f; // ���������, ��� �������� ������� ���������� ����� ������ �����

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
