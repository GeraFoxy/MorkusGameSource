using UnityEngine;

public class DeathPrefs : MonoBehaviour
{

    void Start()
    {
        if (!PlayerPrefs.HasKey("deathCount"))
        {
            PlayerPrefs.SetInt("deathCount", 0);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("deathCount", 0);
            PlayerPrefs.Save();
        }
    }


}
