using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	public static GameOver Instance;
	public Text scoreText;
	
	private void Awake()
	{
		Instance = this;
	}
	
	public void Retry()
	{
		Time.timeScale = 1;
		SceneManagement.LoadScene("Game");
	}
	
	public void BackToMenu()
	{
		Time.timeScale = 1;
		SceneManagement.LoadScene("Menu");
	}
	
	public static void Zeig()
	{
		if(!Instance)
		{
			Time.timeScale = 0;
			Instantiate(Resources.Load<GameObject>("GameOver"));
		}
	}
}
