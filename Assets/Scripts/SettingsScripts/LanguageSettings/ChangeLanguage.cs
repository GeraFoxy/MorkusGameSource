using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    public Text playGameText;
    public Text SettingsText;
    public Text ExitText;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Language"))
        {
            PlayerPrefs.SetInt("Language", 1);
            PlayerPrefs.Save();
        }
        CheckLanguageFlag();
    }

    public void ChangeEnLanguage()
    {
        PlayerPrefs.SetInt("Language", 1);
        PlayerPrefs.Save();

        CheckLanguageFlag();
    }

    public void ChangeRuLanguage()
    {
        PlayerPrefs.SetInt("Language", 2);
        PlayerPrefs.Save();

        CheckLanguageFlag();
    }

    private void CheckLanguageFlag()
    {
        int LanguageFlag = PlayerPrefs.GetInt("Language");

        if(LanguageFlag == 1)
        {
            playGameText.text = "PLAY";
            SettingsText.text = "SETTINGS";
            ExitText.text = "EXIT";
        }
        else if(LanguageFlag == 2)
        {
            playGameText.text = "»√–¿“‹";
            SettingsText.text = "Œœ÷»»";
            ExitText.text = "¬€…“»";
        }
    }
}
