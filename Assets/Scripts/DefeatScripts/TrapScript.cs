using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ПроверОчка на столкновение с трапиком
        if (other.CompareTag("Trap"))
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
}
