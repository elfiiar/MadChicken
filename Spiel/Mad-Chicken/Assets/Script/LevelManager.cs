using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //Stein ist aus dem Internet: http://www.blendswap.com/blends/view/70925#
    //Scheune ist aus dem Internet - https://i.pinimg.com/736x/d3/7e/b5/d37eb53f257e3fe43c52829f1a3c2a9b--hand-painted-textures-d-texture.jpg
    //Block ist aus dem Internet: https://3dlancer.net/en/3dmodel-3d-wooden-fence-game-asset---low-poly-24805


    //Idee ist teilweise von https://www.youtube.com/watch?v=8QDwcJIZz9w&t=70s ; größtenteils selbst

    //Auto-Init
    private GameObject player;

    //Entfernung bevor neuem SPawn
    private const float spawnOffset = 100.0f;
    //max Segmente auf dem Feld
    private const int maxSegments = 15;

    //aktive Segmente auf dem Feld
    private int activeSegments;
    //aktuelle z-Position der Spawnz
    private int SpawnZ;

    //Länge pro Segment
    public int lengthproSegment = 20;

    //Lists
    //Liste der verfügbaren Segmente
    public List<GameObject> availableSegments = new List<GameObject>();
    //Liste aller Segmente die gespawnt wurden
    [HideInInspector]
    public List<GameObject> segments = new List<GameObject>();

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SpawnZ = 0;

        //Am Anfang 10 Segmente spawnen
        for (int i = 0; i < 10; i++)
        {
            SpawnSegment();
        }
    }

    private void Update()
    {
        //spawnt weitere Segmente sobald die Entfernung zum letzten Segment weniger als 100 beträgt
        if(SpawnZ - player.transform.position.z < spawnOffset){
            SpawnSegment();
        }

        //schaut das nicht mehr als 15 Segmente aktiv sind
        if(activeSegments >= maxSegments){
            segments[activeSegments - 1].SetActive(false);
            activeSegments--;
        }
    }


    private void SpawnSegment()
    {
        //id = eine Random Zahl zwischen 0 und availableSegments(in unserem Fall 15)
        int id = Random.Range(0, availableSegments.Count);

        //erstellt ein Gameobject go und Instantiatet ein Segment aus der Liste mit dem Index (id)
        GameObject go = Instantiate(availableSegments[id].gameObject) as GameObject;
        //go wird in Index 0 eingefügt
        segments.Insert(0, go);

        //go wird LevelMananger als child hinzugefügt
        go.transform.SetParent(transform);
        //positioniert in der z Achse * derzeitigerSpawnz
        go.transform.localPosition = Vector3.forward * SpawnZ;

        //DerzeitigerSpawnZ += Länge vom Segment 
        SpawnZ += lengthproSegment;
        //anzahlAktiverSegmente wird addiert
        activeSegments++;
    }
}  

