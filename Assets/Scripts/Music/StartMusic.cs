using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour
{
    public static StartMusic Instance { get; private set; }
    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    [SerializeField] private Slider musicSlider;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        if (backgroundMusic != null)
        {
            PlayBackgroundMusic(false, backgroundMusic);
        }
        
        musicSlider.onValueChanged.AddListener(delegate { SetVolume(musicSlider.value); });
    }

    public static void SetVolume(float volume)
    {
        Instance.audioSource.volume = volume;
    }

    public void PlayBackgroundMusic(bool resetSong, AudioClip audioClip = null)
    {
        if (audioClip != null)
        {
            audioSource.clip = audioClip;
        }
        if (audioSource.clip != null)
        {
            if (resetSong)
            {
                audioSource.Stop();
            }

            audioSource.Play();
        }
    }

    public void stopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
