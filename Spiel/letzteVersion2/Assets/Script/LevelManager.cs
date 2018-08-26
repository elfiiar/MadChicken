using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Stein ist aus dem Internet: http://www.blendswap.com/blends/view/70925#
    //Scheune ist aus dem Internet - https://i.pinimg.com/736x/d3/7e/b5/d37eb53f257e3fe43c52829f1a3c2a9b--hand-painted-textures-d-texture.jpg
    //Block ist aus dem Internet: https://3dlancer.net/en/3dmodel-3d-wooden-fence-game-asset---low-poly-24805


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

