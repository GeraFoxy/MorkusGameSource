using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button defeatButton;      // Кнопка выхода на сцену Defeat
    public Text timeText;            // Текст для отображения времени

    private TimerScript timerScript; // Ссылка на таймер

    private bool isPaused = false;
    private int languageFlag;
    void Start()
    {
        // Изначально курсор скрыт
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Находим компонент TimerScript
        timerScript = Object.FindFirstObjectByType<TimerScript>();

        languageFlag = PlayerPrefs.GetInt("Language");
    }

    void Update()
    {
        // Проверяем нажатие клавиши Escape
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
            timeText.text = "Время: " + timerScript.GetRemainingTime().ToString("F2") + "c";

        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        // Блокировка курсора
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None; // Разблокировать курсор
            Cursor.visible = true; // Сделать курсор видимым
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // Заблокировать курсор
            Cursor.visible = false; // Сделать курсор невидимым
        }
    }

    public void OnDefeatButtonClicked()
    {
        // курсор становится видимым перед переходом на сцену
        Cursor.visible = true; // Показываем курсор перед переходом на сцену
        Cursor.lockState = CursorLockMode.None; // Разблокировать курсор
        Time.timeScale = 1f; // Убедитесь, что скорость времени нормальная перед сменой сцены

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
