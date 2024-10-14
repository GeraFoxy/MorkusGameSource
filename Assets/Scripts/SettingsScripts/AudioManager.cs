using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;  // Привяжи AudioSource из текущей сцены
    public Slider volumeSlider;      // Привяжи слайдер громкости

    void Start()
    {
        // Проверяем, есть ли сохранённое значение громкости, и устанавливаем его для AudioSource
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume");
            audioSource.volume = savedVolume;
            volumeSlider.value = savedVolume;
        }
        else
        {
            // Если нет сохранённого значения, ставим громкость по умолчанию (1.0)
            audioSource.volume = 1.0f;
            volumeSlider.value = 1.0f;
        }

        // Подписываемся на изменение слайдера
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    // Метод для изменения громкости
    public void ChangeVolume(float volume)
    {
        // Меняем громкость на всех сценах через PlayerPrefs
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
    }
}

