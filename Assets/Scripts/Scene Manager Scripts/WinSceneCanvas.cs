using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneCanvas : MonoBehaviour
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

}
