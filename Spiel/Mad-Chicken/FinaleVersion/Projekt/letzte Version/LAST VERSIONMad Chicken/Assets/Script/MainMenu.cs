using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// ruft von Play button
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// ruft von Slider in MainMenu
    /// </summary>
    public AudioSource myMusic;

    public void UpdateVolume(float t)
    {
        AudioListener.volume = t;
    }
}
