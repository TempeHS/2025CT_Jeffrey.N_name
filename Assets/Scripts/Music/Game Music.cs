using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMusic : MonoBehaviour
{
    public static GameMusic Instance { get; private set; }
    private AudioSource audioSource;
    private Coroutine musicLoopCoroutine;
    public List<AudioClip> musicPlaylist = new List<AudioClip>();
    [SerializeField] private Slider musicSlider;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
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

    public void startGameMusic()
    {
        if (musicPlaylist != null && musicPlaylist.Count > 0)
        {
            AudioClip selectedClip = musicPlaylist[Random.Range(0, musicPlaylist.Count)];
            audioSource.clip = selectedClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No background music assigned in MusicManager.");
        }
    }

    private IEnumerator PlayRandomMusic()
    {
        while (true)
        {
            AudioClip nextclip = GetRandomClip();
            if (nextclip != null)
            {
                audioSource.clip = nextclip;
                audioSource.Play();
                Debug.Log("Playing" + nextclip.name);

                yield return new WaitForSeconds(nextclip.length);
            }
            else
            {
                yield return null;
            }
        }
    }

    private AudioClip GetRandomClip()
    {
        if (musicPlaylist.Count == 0) return null;

        return musicPlaylist[Random.Range(0, musicPlaylist.Count)];
    }
}
