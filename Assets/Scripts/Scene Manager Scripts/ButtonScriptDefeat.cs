using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScriptDefeat : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Man Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Levels Map");
    }


}
