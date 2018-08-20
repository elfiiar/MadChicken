using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager Instance { set; get; }

    public bool SHOW_COLLIDER = true;

    //Level Spawning
    private const float DISTANCE_BEFORE_SPAWN = 100.0f;
    private const float INITIAL_SEGMENTS = 10;
    private const int MAX_SEGMENTS_ON_SCREEN = 15;
    private Transform cameraContainer;
    private int amountOfActiveSegments;
    private int continiousSegments;
    private int currentSpawnZ;
    private int currentLevel;
    private int y1, y2, y3;

    //List of Segments
    public List<Segment> availableSegments = new List<Segment>();
    public List<Segment> availableTransitions = new List<Segment>();
    [HideInInspector]
    public List<Segment> segments = new List<Segment>();

    //Gameplay
    private bool isMoving = false;


    private void Awake()
    {
        Instance = this;
        cameraContainer = Camera.main.transform;
        currentSpawnZ = 0;
        currentLevel = 0;

    }

    private void Start()
    {
        for (int i = 0; i < INITIAL_SEGMENTS; i++)
        {
            
            GenerateSegment();
        }
    }

    private void Update()
    {
        if(currentSpawnZ - cameraContainer.position.z < DISTANCE_BEFORE_SPAWN){
            GenerateSegment();
        }

        if(amountOfActiveSegments >= MAX_SEGMENTS_ON_SCREEN){
            segments[amountOfActiveSegments - 1].DeSpawn();
            amountOfActiveSegments--;
        }
    }

    private void GenerateSegment(){
        SpawnSegment();

        if(Random.Range(0f, 1f)<(continiousSegments * 0.25f)){
            //Spawn transition segment
            continiousSegments = 0;
            SpawnTransition();
        } 
        else
        {
            continiousSegments++;
        }
    }

    private void SpawnSegment(){
        List<Segment> possibleSeg = availableSegments.FindAll(x => x.beginY1 == y1 || x.beginY2 == y2 || x.beginY3 == y3);
        int id = Random.Range(0, possibleSeg.Count);

        Segment s = GetSegment(id, false);

        y1 = s.endY1;
        y2 = s.endY2;
        y3 = s.endY3;

        s.transform.SetParent(transform);
        s.transform.localPosition = Vector3.forward * currentSpawnZ;

        currentSpawnZ += s.length;
        amountOfActiveSegments++;
        s.Spawn();
    }

    private void SpawnTransition(){
        List<Segment> possibleTrans = availableTransitions.FindAll(x => x.beginY1 == y1 || x.beginY2 == y2 || x.beginY3 == y3);
        int id = Random.Range(0, possibleTrans.Count);

        Segment s = GetSegment(id, true);

        y1 = s.endY1;
        y2 = s.endY2;
        y3 = s.endY3;

        s.transform.SetParent(transform);
        s.transform.localPosition = Vector3.forward * currentSpawnZ;

        currentSpawnZ += s.length;
        amountOfActiveSegments++;
        s.Spawn();
    }

    public Segment GetSegment(int id, bool transition){
        Segment s = null;
        s = segments.Find(x => x.SegID == id && x.transition == transition && !x.gameObject.activeSelf);

        if(s==null){
            GameObject go = Instantiate((transition) ? availableTransitions[id].gameObject : availableSegments[id].gameObject) as GameObject;
            s = go.GetComponent<Segment>();

            s.SegID = id;
            s.transition = transition;

            segments.Insert(0, s);
        }
        else
        {
            segments.Remove(s);
            segments.Insert(0, s);
        }

        return s;
    }
}  

