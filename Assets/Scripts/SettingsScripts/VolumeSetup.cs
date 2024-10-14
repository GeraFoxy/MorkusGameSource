using UnityEngine;

public class VolumeSetup : MonoBehaviour
{
    public AudioSource audioSource;  

    void Start()
    {
        // Сохранённая громкость из настроек
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume");
            audioSource.volume = savedVolume;
        }
        else
        {
            audioSource.volume = 1.0f; // Громкость по умолчанию
        }
    }
}
