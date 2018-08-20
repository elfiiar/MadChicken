using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour {

    //max Anzahl der Eier
	public int maxEgg = 5;
    //Chance etwas zu spawnen (sehr hoch)
    public float chanceToSpawn = 0.9f;

    private GameObject[] eggs;

    private void Awake()
    {
        //Größe des Arrays ist die Anzahl der Kindsknoten 
        eggs = new GameObject[transform.childCount];

        //füllt Array mit Gameobjekten
        for (int i = 0; i < transform.childCount; i++)
        {
            eggs[i] = transform.GetChild(i).gameObject;
        }

        OnDisable();
    }

    private void OnEnable()
    {
        //schaut ob etwas gespawnt werden soll
        if (Random.Range(0.0f, 1.0f) > chanceToSpawn)
        {
            return;
        }

        //schaut wie viel gespawnt werden soll
        int r = Random.Range(0, maxEgg);
        for (int i = 0; i < r; i++)
        {
                eggs[i].SetActive(true);

        }
    
    }

    private void OnDisable()
    {
        foreach(GameObject go in eggs){
            go.SetActive(false);
        }
    }

}
