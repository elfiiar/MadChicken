using System.Collections;
using UnityEngine;

public class Sonne2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, 10f * Time.deltaTime);
        //Dreht sich um den 0 Punkt nach rechts mit 10f Geschwindigkeit
        transform.LookAt(Vector3.zero);
    }
}