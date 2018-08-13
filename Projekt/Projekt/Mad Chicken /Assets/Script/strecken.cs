using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour
{
    public Transform strecke;
    public float ScenePositon = 150;
    public float ScenePositionObj = 5;
    public float ScenePositionScheune = 10;
    public float ScenePositionSC = 5;



    public Transform eggObj;
    public Transform steinObj;
    public Transform blockerObj;
    public Transform scheuneObj;
    public Transform scheune2Obj;
    public Transform schafeObj;
    public Transform scarecrowobj;

    public float time;

    public int randNum;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ScenePositionObj < 500)
        {
            randNum = Random.Range(0, 27);
            if (randNum == 1 || randNum == 2 || randNum == 3 )
            {
                var childobj = Instantiate(eggObj, new Vector3(0, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 4 || randNum == 5 || randNum == 6)
            {
                var childobj = Instantiate(eggObj, new Vector3(2, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 7 || randNum == 8 || randNum == 9)
            {
                var childobj = Instantiate(eggObj, new Vector3(-2, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;
            }

            if (randNum == 10|| randNum == 11)
            {
                var childobj = Instantiate(blockerObj, new Vector3(0, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 12|| randNum == 13)
            {
                var childobj = Instantiate(blockerObj, new Vector3(2, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 14|| randNum == 15 )
            {
                var childobj = Instantiate(blockerObj, new Vector3(-2, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 16|| randNum == 17 )
            {
                var childobj = Instantiate(scheuneObj, new Vector3(2, 0, ScenePositionScheune), scheuneObj.rotation);
                var childobj2 = Instantiate(scheune2Obj, new Vector3(-2, 0, ScenePositionScheune), scheune2Obj.rotation);
                childobj.transform.parent = transform;
                childobj2.transform.parent = transform;

            }
            if (randNum == 18 || randNum == 19 )
            {
                var childobj = Instantiate(steinObj, new Vector3(2, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 20|| randNum == 21)
            {
                var childobj = Instantiate(steinObj, new Vector3(-2, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 22|| randNum == 23)
            {
                var childobj = Instantiate(steinObj, new Vector3(0, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 24)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(2, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 25)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(0, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 26)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(-2, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
        

            ScenePositionObj += 5;
            ScenePositionScheune += 11;
            ScenePositionSC += 16;
        }
    




        if (ScenePositon < 1000)
        {
            
            var child = Instantiate(strecke, new Vector3(0, 0, ScenePositon), transform.rotation);
            child.transform.parent = transform;
            ScenePositon += 100f;

        }


    }
}

