using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public Slider Volume;
    public AudioSource myMusic;
    public AudioMixer audioMixer;
    /// <summary>
    /// ruft von Play button
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        myMusic.volume = Volume.value;
    }
    /// <summary>
    /// ruft von Slider in MainMenu
    /// </summary>
    /// 
    /*
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    */
}
