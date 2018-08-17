using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour
{
    public GameObject strecke;
    public float scenePositon = 250;
    private GameObject player;
    private bool setOnlyOneTime = true;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //erstellt pro Frame, der durch 100 teilbar ist, ein Prefab der Strecke
        int z = (int)player.transform.position.z;
        Debug.Log(z);
        if (z % 100 == 0 && setOnlyOneTime)
        {
            var child = Instantiate(strecke, new Vector3(0, 0, scenePositon), strecke.transform.rotation);
            child.transform.parent = transform;
            scenePositon += 100f;
            setOnlyOneTime = false;
            Debug.Log("strecke erweitert");
        } 
        else if(z % 100 != 0)
        {
            setOnlyOneTime = true;
        }
    }
}

