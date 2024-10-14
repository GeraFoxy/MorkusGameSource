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
        "\tДобро пожаловать в заброшенное и зловещее измерение, известное как Моркус. Это место — забвение для тех, кто осмелился бросить вызов воле святых. Здесь царит молчание и одиночество, где каждое мгновение кажется вечностью. Никто не кричит, никто не плачет, ибо всё бессмысленно в этом безжизненном мире. " +
            "Страшный голод медленно разъедает твое тело и разум, заставляя тебя чувствовать, как будто сама сущность твоего бытия испаряется.",
        "   Ты слышишь шепот? Это боги. Они даровали тебе искру надежды, но цена за неё высока. Где-то здесь, в переплетениях бесконечных лабиринтов, спрятано заветное печенье. Но не обольщайся — чтобы вернуться домой, тебе предстоит отыскать не одно, а целых пять печенек. Каждая из них — шаг ближе к свободе. " +
        "Но если ты потерпишь неудачу, если не уложишься в два коротких мгновения — ты будешь отброшен на самое начало пути.",
        "   Каждый новый круг Моркуса полон ловушек, которые появляются всё чаще и коварнее. Ты почувствуешь, как стены замыкаются вокруг тебя, а полные страха шаги будут вести тебя всё дальше в бездну. " +
        "С каждым новым уровнем, с каждым неудачным поиском, лабиринт будет казаться всё более непреодолимым, а твой разум — всё более сломленным.",
        "   Ты можешь начать думать: а стоит ли продолжать? Разве не проще смириться и остаться здесь, вечно блуждать среди этих холодных стен, чем продолжать бороться? Но тогда ты утратишь всё, что у тебя есть в мире. " +
        "Ты пожертвуешь теми, кто ждет тебя на другой стороне, и тем, что делает тебя человеком. Неужели ты готов бросить их и позволить этому месту поглотить твою душу? Или же ты готов сражаться до конца, искать спасение даже в безнадежности?",
        "   Выбор за тобой. Найди печенье, победи Лабиринт-Моркус, или останься здесь навсегда.\n\nУдачи, смертный. Она тебе действительно понадобится.\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\tГосподь."
        };
    private string[] paragraphsEN =
    {
    "   Welcome to the abandoned and eerie dimension known as Morcus. This place is a void for those who dared to defy the will of the gods. Here, silence and loneliness reign, where every moment feels like an eternity. No one screams, no one cries, for everything is meaningless in this lifeless world. A terrible hunger slowly eats away at your body and mind, making you feel as if the very essence of your being is evaporating.",
    "   Do you hear the whisper? It's the gods. They've given you a spark of hope, but the price is steep. Somewhere here, within the twists of endless mazes, the coveted cookie is hidden. But don’t be deceived—you'll need to find not one, but five cookies to return home. Each one is a step closer to freedom. But if you fail, if you don't make it in two brief moments—you'll be cast back to the very beginning of your journey.",
    "   Each new circle of Morcus is full of traps that become more frequent and treacherous. You'll feel the walls closing in around you, and your fearful steps will lead you deeper into the abyss. With each new level, with each failed search, the maze will seem more insurmountable, and your mind ever more broken.",
    "   You might begin to wonder: is it worth continuing? Isn’t it easier to give up and stay here, wandering forever among these cold walls, rather than keep fighting? But if you do, you'll lose everything you have in the world. You'll sacrifice those waiting for you on the other side, and everything that makes you human. Are you truly willing to abandon them and let this place consume your soul? Or will you fight until the end, searching for salvation even in hopelessness?",
    "   The choice is yours. Find the cookie, defeat the Maze of Morcus, or remain here forever.\n\nGood luck, mortal. You’ll surely need it.\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\tThe Lord."
};



    private int currentParagraphIndex = 0;
    private int languageFlag;

    private void Start()
    {
        // существует ли cookieCount
        if (!PlayerPrefs.HasKey("cookieCount"))
        {
            PlayerPrefs.SetInt("cookieCount", 1); // Начинается с 1
        }

        // Получаем текущее значение cookieCount
        int cookieCount = PlayerPrefs.GetInt("cookieCount");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        languageFlag = PlayerPrefs.GetInt("Language");

    }

    private void UpdateLevelButtons()
    {
        int cookieCount = PlayerPrefs.GetInt("cookieCount");

        // Активируем кнопки в зависимости от cookieCount
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
                Debug.Log("Все абзацы показаны.");
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
                Debug.Log("Все абзацы показаны.");
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
