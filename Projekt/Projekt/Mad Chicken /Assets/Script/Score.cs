using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    public static int score;    
    public static float time;


    Text text;                     

    void Awake()
    {
        text = GetComponent<Text>();
        time += Time.deltaTime;


    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;


    }
}