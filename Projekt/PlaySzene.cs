using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlaySzene : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene (sceneIndex);
    }
}