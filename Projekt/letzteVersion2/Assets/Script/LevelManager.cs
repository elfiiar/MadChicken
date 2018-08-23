using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    //Idee&Code ist teilweise von https://www.youtube.com/watch?v=8QDwcJIZz9w&t=70s; teilweise selbst

    private GameObject player;

    private const float entfernungVorSpawning = 100.0f;
    private const int maxSegments = 15;

    private int anzahlAktiverSegmente;
    private int derzeitigerSpawnZ;
    private int y1, y2, y3;

    //Lists
    public List<Segment> availableSegments = new List<Segment>();
    //[HideInInspector]
    public List<Segment> segments = new List<Segment>();

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
            segments[anzahlAktiverSegmente - 1].DeSpawn();
          //  segments.RemoveAt(anzahlAktiverSegmente - 1);
            anzahlAktiverSegmente--;
        }
    }


    private void SpawnSegment()
    {
        List<Segment> possibleSeg = availableSegments.FindAll(x => x.beginY1 == y1 || x.beginY2 == y2 || x.beginY3 == y3);
        int id = Random.Range(0, possibleSeg.Count);

        //erstellt ein Gameobject go und Instantiatet ein Segment aus der Liste mit dem Index (id)
        //Segment s wird dann GetComponent von typ Segment zugewiesen
        //s wird in Index 0 eingefügt
        GameObject go = Instantiate(availableSegments[id].gameObject) as GameObject;
        Segment s = go.GetComponent<Segment>();
        segments.Insert(0, s);

        y1 = s.endY1;
        y2 = s.endY2;
        y3 = s.endY3;

        //s wird LevelMananger als child hinzugefügt
        s.transform.SetParent(transform);
        //positioniert in der z Achse * derzeitigerSpawnz
        s.transform.localPosition = Vector3.forward * derzeitigerSpawnZ;

        //DerzeitigerSpawnZ +=Länge vom Segment 
        derzeitigerSpawnZ += s.length;
        //anzahlAktiverSegmente wird addiert
        anzahlAktiverSegmente++;
    }
}  

