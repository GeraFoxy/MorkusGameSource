using UnityEngine;
using UnityEngine.UI;

public class DeathCount : MonoBehaviour
{
    [SerializeField] private Text deathCountText; 

    void Start()
    {
        int languageFlag = PlayerPrefs.GetInt("Language");

        int deathCount = PlayerPrefs.GetInt("deathCount");
        deathCount++;
        PlayerPrefs.SetInt("deathCount", deathCount);
        PlayerPrefs.Save();

        if (languageFlag == 1)
        {
            deathCountText.text = "Number of defeats: " + deathCount.ToString();
        }
        else if (languageFlag == 2)
        {
            deathCountText.text = "Количество поражений: " + deathCount.ToString();

        }

    }


}
