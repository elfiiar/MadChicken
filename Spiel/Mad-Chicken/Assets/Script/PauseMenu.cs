using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        /*
         * Wenn man die Space Taste betätigt, erscheint das Canvas PauseMenü
         * mit wiederholtem Space kehrt man wiederholt zum Spiel zurück.
         */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        //Wenn man die Pause aufgehoben wird(false), setz sich das fort.GIP (false)
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        //Wenn Pause aktiviert worden ist (true), wir die Zeit gestoppt. GIP(true)
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //Betätigt man die M Taste geht man zurück auf die Startmenü Szene
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void Quit()
    {
        //Betätigt man die Escape Taste schließt die App.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
            
    }
}

