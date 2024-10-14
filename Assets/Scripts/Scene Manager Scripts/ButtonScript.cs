using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public Button levelButton1;
    public Button levelButton2; 
    public Button levelButton3;
    public Button levelButton4; 
    public Button levelButton5; 
    public Text displayText;
    
    private string[] paragraphsRU =
        {
        "\t����� ���������� � ����������� � �������� ���������, ��������� ��� ������. ��� ����� � �������� ��� ���, ��� ��������� ������� ����� ���� ������. ����� ����� �������� � �����������, ��� ������ ��������� ������� ���������. ����� �� ������, ����� �� ������, ��� �� ������������ � ���� ������������ ����. " +
            "�������� ����� �������� ��������� ���� ���� � �����, ��������� ���� �����������, ��� ����� ���� �������� ������ ����� ����������.",
        "   �� ������� �����? ��� ����. ��� �������� ���� ����� �������, �� ���� �� �� ������. ���-�� �����, � ������������� ����������� ����������, �������� �������� �������. �� �� ���������� � ����� ��������� �����, ���� ��������� �������� �� ����, � ����� ���� �������. ������ �� ��� � ��� ����� � �������. " +
        "�� ���� �� ��������� �������, ���� �� ��������� � ��� �������� ��������� � �� ������ �������� �� ����� ������ ����.",
        "   ������ ����� ���� ������� ����� �������, ������� ���������� �� ���� � ��������. �� ������������, ��� ����� ���������� ������ ����, � ������ ������ ���� ����� ����� ���� �� ������ � ������. " +
        "� ������ ����� �������, � ������ ��������� �������, �������� ����� �������� �� ����� �������������, � ���� ����� � �� ����� ����������.",
        "   �� ������ ������ ������: � ����� �� ����������? ����� �� ����� ��������� � �������� �����, ����� �������� ����� ���� �������� ����, ��� ���������� ��������? �� ����� �� �������� ��, ��� � ���� ���� � ����. " +
        "�� ����������� ����, ��� ���� ���� �� ������ �������, � ���, ��� ������ ���� ���������. ������� �� ����� ������� �� � ��������� ����� ����� ��������� ���� ����? ��� �� �� ����� ��������� �� �����, ������ �������� ���� � �������������?",
        "   ����� �� �����. ����� �������, ������ ��������-������, ��� �������� ����� ��������.\n\n�����, ��������. ��� ���� ������������� �����������.\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t�������."
        };
    private string[] paragraphsEN =
    {
    "   Welcome to the abandoned and eerie dimension known as Morcus. This place is a void for those who dared to defy the will of the gods. Here, silence and loneliness reign, where every moment feels like an eternity. No one screams, no one cries, for everything is meaningless in this lifeless world. A terrible hunger slowly eats away at your body and mind, making you feel as if the very essence of your being is evaporating.",
    "   Do you hear the whisper? It's the gods. They've given you a spark of hope, but the price is steep. Somewhere here, within the twists of endless mazes, the coveted cookie is hidden. But don�t be deceived�you'll need to find not one, but five cookies to return home. Each one is a step closer to freedom. But if you fail, if you don't make it in two brief moments�you'll be cast back to the very beginning of your journey.",
    "   Each new circle of Morcus is full of traps that become more frequent and treacherous. You'll feel the walls closing in around you, and your fearful steps will lead you deeper into the abyss. With each new level, with each failed search, the maze will seem more insurmountable, and your mind ever more broken.",
    "   You might begin to wonder: is it worth continuing? Isn�t it easier to give up and stay here, wandering forever among these cold walls, rather than keep fighting? But if you do, you'll lose everything you have in the world. You'll sacrifice those waiting for you on the other side, and everything that makes you human. Are you truly willing to abandon them and let this place consume your soul? Or will you fight until the end, searching for salvation even in hopelessness?",
    "   The choice is yours. Find the cookie, defeat the Maze of Morcus, or remain here forever.\n\nGood luck, mortal. You�ll surely need it.\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\tThe Lord."
};



    private int currentParagraphIndex = 0;
    private int languageFlag;

    private void Start()
    {
        // ���������� �� cookieCount
        if (!PlayerPrefs.HasKey("cookieCount"))
        {
            PlayerPrefs.SetInt("cookieCount", 1); // ���������� � 1
        }

        // �������� ������� �������� cookieCount
        int cookieCount = PlayerPrefs.GetInt("cookieCount");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        languageFlag = PlayerPrefs.GetInt("Language");

    }

    private void UpdateLevelButtons()
    {
        int cookieCount = PlayerPrefs.GetInt("cookieCount");

        // ���������� ������ � ����������� �� cookieCount
        levelButton1.interactable = (cookieCount >= 1);
        levelButton2.interactable = (cookieCount >= 2);
        levelButton3.interactable = (cookieCount >= 3);
        levelButton4.interactable = (cookieCount >= 4);
        levelButton5.interactable = (cookieCount >= 5);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Intro");

    }

    public void ToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Man Menu");

    }

    public void NextText()
    {
        
        if (languageFlag == 1)
        {
            if (currentParagraphIndex < paragraphsEN.Length)
            {
                displayText.text = paragraphsEN[currentParagraphIndex]; 
                currentParagraphIndex++;  
            }
            else
            {
                Debug.Log("��� ������ ��������.");
            }

        }
        else if (languageFlag == 2)
        {
            if (currentParagraphIndex < paragraphsRU.Length)
            {
                displayText.text = paragraphsRU[currentParagraphIndex];
                currentParagraphIndex++;
            }
            else
            {
                Debug.Log("��� ������ ��������.");
            }
        }


    }

    public void ToLevelMap()
    {
        SceneManager.LoadScene("Levels Map"); 

    }

    public void ToFirstLevel()
    {
        SceneManager.LoadScene("level 1");

    }

    public void ToSecondLevel()
    {
        SceneManager.LoadScene("level 2");

    }

    public void ToThirdLevel()
    {
        SceneManager.LoadScene("level 3");

    }

    public void ToFourthLevel()
    {
        SceneManager.LoadScene("Level 4");
    
    }

    public void ToFivethLevel()
    {
        SceneManager.LoadScene("level 5");

    }

    public void ExitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }

    private void Update()
    {
        UpdateLevelButtons();
    }
}
