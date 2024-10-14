using UnityEngine;
using UnityEngine.UI;

public class GameLanguage : MonoBehaviour
{
    public Text GiveUp;
    void Start()
    {
        int LanguageFlag = PlayerPrefs.GetInt("Language");

        if (LanguageFlag == 1)
        {
            GiveUp.text = "Give up";
        }
        else if (LanguageFlag == 2)
        {
            GiveUp.text = "—ƒ¿“‹—ﬂ";
        }
    }

}
