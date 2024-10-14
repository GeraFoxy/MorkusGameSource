using UnityEngine;
using UnityEngine.UI;
public class WinLanguage : MonoBehaviour
{
    public Text WinButton;
    public Text WinText;
    void Start()
    {
        int LanguageFlag = PlayerPrefs.GetInt("Language");

        if (LanguageFlag == 1)
        {
            WinButton.text = "WIN";
            WinText.text = "Congratulations, mortal. Your trial is complete. The world you once knew is open to you again�your friends, family, and home await. The gods no longer bear any ill will toward you, and you may return to the light. " +
                "But remember: the shadow of Morcus will always be near, and should you ever dare to defy the will of the gods again, the path back may no longer exist.\r\nGo, live, and enjoy your freedom. You have earned it.";
        }
        else if (LanguageFlag == 2)
        {
            WinButton.text = "������";
            WinText.text = "�����������, ��������. ��� ��������� ���������. ���, ������� �� ����, ����� ������ ��� ���� � ��� ���� ������, ����� � ���. ���� ������ �� ������ �� ���� ��� � �� ������ ��������� � �����. �� �� �������: ���� ������� ������ ����� �����, " +
                "� ���� �����-������ �� ����� ���������� ������� ����� ������, ���� ����� ����� ��� �� ������������. \r\n���, ����, ����������� ��������. �� �������� �.";
        }
    }

}
