using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    //Idee ist teilweise von https://www.youtube.com/watch?v=8QDwcJIZz9w&t=70s ; größtenteils selbst

    private GameObject player;

    private const float entfernungVorSpawning = 100.0f;
    private const int maxSegments = 15;

    private int anzahlAktiverSegmente;
    private int derzeitigerSpawnZ;
    private int y1, y2, y3;

    public int lengthproSegment = 15;

    //Lists
    public List<GameObject> availableSegments = new List<GameObject>();
    //[HideInInspector]
    public List<GameObject> segments = new List<GameObject>();

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        derzeitigerSpawnZ = 0;
    }

    private void Start()
    {
        //Am Anfang 10 Segmente spawnen
        for (int i = 0; i < 10; i++)
        {
            SpawnSegment();
        }
    }

    private void Update()
    {
        //spawnt weitere Segmente sobald die Entfernung zum letzten Segment weniger als 100 beträgt
        if(derzeitigerSpawnZ - player.transform.position.z < entfernungVorSpawning){
            SpawnSegment();
        }

        //schaut das nicht mehr als 15 Segmente aktiv sind
        if(anzahlAktiverSegmente >= maxSegments){
            segments[anzahlAktiverSegmente - 1].SetActive(false);
            anzahlAktiverSegmente--;
        }
    }


    private void SpawnSegment()
    {
        //erstellt ein Gameobject go und Instantiatet ein Segment aus der Liste mit dem Index (id)
        //go wird in Index 0 eingefügt
        //go wird LevelMananger als child hinzugefügt
        //positioniert in der z Achse * derzeitigerSpawnz
        //DerzeitigerSpawnZ += Länge vom Segment 
        //anzahlAktiverSegmente wird addiert

        int id = Random.Range(0, availableSegments.Count);
       
        GameObject go = Instantiate(availableSegments[id].gameObject) as GameObject;
        segments.Insert(0, go);

        go.transform.SetParent(transform);
        go.transform.localPosition = Vector3.forward * derzeitigerSpawnZ;

        derzeitigerSpawnZ += lengthproSegment;
        anzahlAktiverSegmente++;
    }
}  

