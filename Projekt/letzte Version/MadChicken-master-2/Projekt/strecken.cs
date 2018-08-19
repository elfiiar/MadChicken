using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour
{
    public Transform strecke;
    public float ScenePositon = 150;
    public float ScenePositionObj = 25;
    public float ScenePositionScheune = 10;
    public float ScenePositionSC = 25;
    public float ScenePositionEgg = 25;




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
            randNum = Random.Range(0, 15);
            //______________Eggs_____________

            if (randNum == 1 )
            {
                for (int i = 0; i < 5; i++)
                {
                    var childobj = Instantiate(eggObj, new Vector3(0, 1, ScenePositionEgg+=3), eggObj.rotation);
                    childobj.transform.parent = transform;
                }
            }
            if (randNum == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    var childobj = Instantiate(eggObj, new Vector3(2, 1, ScenePositionEgg += 3), eggObj.rotation);
                    childobj.transform.parent = transform;
                }
            }
            if (randNum == 3 )
            {
                for (int i = 0; i < 5; i++)
                {
                    var childobj = Instantiate(eggObj, new Vector3(-2, 1, ScenePositionEgg += 3), eggObj.rotation);
                    childobj.transform.parent = transform;
                }
            }

            //______________Blocker_____________
            if (randNum == 4)
            {
                var childobj = Instantiate(blockerObj, new Vector3(0, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 5)
            {
                var childobj = Instantiate(blockerObj, new Vector3(2, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 6)
            {
                var childobj = Instantiate(blockerObj, new Vector3(-2, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }

            //______________Scheune_____________

            if (randNum == 7)
            {
                var childobj = Instantiate(scheuneObj, new Vector3(2, 0, ScenePositionScheune), scheuneObj.rotation);
                var childobj2 = Instantiate(scheune2Obj, new Vector3(-2, 0, ScenePositionScheune), scheune2Obj.rotation);
                childobj.transform.parent = transform;
                childobj2.transform.parent = transform;

            }

            //______________Stein_____________

            if (randNum == 8)
            {
                var childobj = Instantiate(steinObj, new Vector3(2, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 9)
            {
                var childobj = Instantiate(steinObj, new Vector3(-2, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 10)
            {
                var childobj = Instantiate(steinObj, new Vector3(0, 0, ScenePositionObj), steinObj.rotation);
                childobj.transform.parent = transform;

            }
            //______________vogelscheuche_____________

            if (randNum == 11)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(2, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 12)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(0, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 13)
            {
                var childobj = Instantiate(scarecrowobj, new Vector3(-2, 0, ScenePositionSC), scarecrowobj.rotation);
                childobj.transform.parent = transform;

            }
        

            ScenePositionObj += 7;
            ScenePositionScheune += 11;
            ScenePositionSC += 16;
            ScenePositionEgg += 10;

        }
    




        if (ScenePositon < 1000)
        {
            
            var child = Instantiate(strecke, new Vector3(0, 0, ScenePositon), transform.rotation);
            child.transform.parent = transform;
            ScenePositon += 100f;

        }


    }
}

