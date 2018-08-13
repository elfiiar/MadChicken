using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Kollision : MonoBehaviour {
    
    public float warteZeit = 0;

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "verloren")
        {
            // Destroy(this.gameObject);

            SceneManager.LoadScene("GameOver");


        }
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "egg")
        {
            Destroy(other.gameObject);
            Score.score += 1;
        }
    }
}
