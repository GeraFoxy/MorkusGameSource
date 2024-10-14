using UnityEngine;
using UnityEngine.UI;
public class SettingsLanguage : MonoBehaviour
{
    public Text ToMenu;
    public Text Volume;
    public Text Difficulty;
    public Text EasyDifficulty;
    public Text HardDifficulty;
    private void Start()
    {

        int LanguageFlag = PlayerPrefs.GetInt("Language");

        if (LanguageFlag == 1)
        {
            ToMenu.text = "MENU";
            Volume.text = "VOLUME";
            Difficulty.text = "SELECT DIFFICULTY";
            EasyDifficulty.text = "EASY";
            HardDifficulty.text = "HARD";
        }
        else if (LanguageFlag == 2)
        {
            ToMenu.text = "лемч";
            Volume.text = "цпнлйнярэ";
            Difficulty.text = "бшаепхре якнфмнярэ";
            EasyDifficulty.text = "кецйн";
            HardDifficulty.text = "якнфмн";
        }
    }
}
