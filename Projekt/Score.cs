using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //UI
    public Text scoretxt;
    private float score;

	// Use this for initialization
	void Start () {
		
	}
	
    private void Awake()
    {
        UpdateScore();
    }

	// Update is called once per frame
	void Update () {
       
	}



    public void UpdateScore(){
        scoretxt.text = "Score: " + score.ToString();
    }
}
