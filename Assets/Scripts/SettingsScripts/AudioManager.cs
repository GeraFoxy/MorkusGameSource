using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;  // ������� AudioSource �� ������� �����
    public Slider volumeSlider;      // ������� ������� ���������

    void Start()
    {
        // ���������, ���� �� ���������� �������� ���������, � ������������� ��� ��� AudioSource
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float savedVolume = PlayerPrefs.GetFloat("MusicVolume");
            audioSource.volume = savedVolume;
            volumeSlider.value = savedVolume;
        }
        else
        {
            // ���� ��� ����������� ��������, ������ ��������� �� ��������� (1.0)
            audioSource.volume = 1.0f;
            volumeSlider.value = 1.0f;
        }

        // ������������� �� ��������� ��������
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    // ����� ��� ��������� ���������
    public void ChangeVolume(float volume)
    {
        // ������ ��������� �� ���� ������ ����� PlayerPrefs
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
    }
}

