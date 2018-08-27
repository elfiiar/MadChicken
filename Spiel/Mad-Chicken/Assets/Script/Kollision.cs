using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Kollision : MonoBehaviour {

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "verloren")
        {
            // Destroy(this.gameObject);
            Debug.Log(hit.gameObject);
            SceneManager.LoadScene("GameOver");


        }
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "egg")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            Score.score += 1;
        }
    }
}
