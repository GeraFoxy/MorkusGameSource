using UnityEngine;
using UnityEngine.UI;

public class DefeatLanguage : MonoBehaviour
{
    public Text ToMenu;
    public Text Restart;
    public Text LoseText;
    void Start()
    {
        int LanguageFlag = PlayerPrefs.GetInt("Language");

        if (LanguageFlag == 1)
        {
            ToMenu.text = "MENU";
            Restart.text = "RESTART";
            LoseText.text = "AHAHAHAHHAHAHA YOU LOST!";
        }
        else if (LanguageFlag == 2)
        {
            ToMenu.text = "Ã≈Õﬁ";
            Restart.text = "–≈—“¿–“";
            LoseText.text = "¿¿’¿’¿’¿’¿’¿. \n“€ œ–Œ»√–¿À!";
        }
    }

}
