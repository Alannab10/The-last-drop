using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance{get; private set;}
    [SerializeField] AudioSource soundEffects;
    [SerializeField] AudioSource music;
     void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
    public void PlaySFX (AudioClip sound)
    {
        soundEffects.PlayOneShot(sound);
    }
    public void PlayMusic (AudioClip musicSong)
    {
        music.Stop();
        music.clip = musicSong;
        music.Play();
    }
    public void VolumeMusic (float newVolume)
    {
        music.volume = newVolume;
    }
}
