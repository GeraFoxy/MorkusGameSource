using UnityEngine;

public class CookieReset : MonoBehaviour
{
    void Start()
    {

        PlayerPrefs.SetInt("cookieCount", 1); // ���������� � 1
        int cookieCount = 1;
        PlayerPrefs.SetInt("cookieCount", cookieCount);
        PlayerPrefs.Save();

    }

}
