using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    //Erzeugte Objekte um die verschiedenen Animationen anwenden zu können.
    public Slider Volume;
    public AudioSource myMusic;
    public AudioMixer audioMixer;

    public void Play()
    {
        //Lädt die Szene Game per Mausklick
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        //Regelt die Musiklautstärke
        myMusic.volume = Volume.value;
    }
   
}
