using System.Collections;
using UnityEngine;

public class Sonne2 : MonoBehaviour
{
    /*
     * Idee aus https://youtu.be/DmhSWEJjphQ
     */
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, 5f * Time.deltaTime);
        //Dreht sich um den 0 Punkt nach rechts mit f Geschwindigkeit
        transform.LookAt(Vector3.zero);
    }
}