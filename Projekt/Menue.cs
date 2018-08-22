using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
 
public class MainMenu : MonoBehaviour
{
	public void Play()
	{
		SceneManagement.LoadScene("Game");
	}
		
	public void UpdateVolume(float t){
		AudioListener.volume = t;
	}
}
