using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour
{
    public Transform strecke;
    public float ScenePositon = 150;
    public float ScenePositionObj = 50;


    public Transform eggObj;
    public Transform steinObj;
    public Transform blockerObj;
    public Transform scheuneObj;
    public Transform scheune2Obj;
    public Transform schafeObj;

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
            randNum = Random.Range(0, 10);
            if (randNum > 3)
            {
                var childobj = Instantiate(eggObj, new Vector3(0, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 2)
            {
                var childobj = Instantiate(blockerObj, new Vector3(0, 0, ScenePositionObj), blockerObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 3)
            {
                var childobj = Instantiate(scheuneObj, new Vector3(2, 0, ScenePositionObj), scheuneObj.rotation);
                var childobj2 = Instantiate(scheune2Obj, new Vector3(-2, 0, ScenePositionObj), scheune2Obj.rotation);
                childobj.transform.parent = transform;
                childobj2.transform.parent = transform;


            }
            if (randNum == 4)
            {
                var childobj = Instantiate(schafeObj, new Vector3(2, 1, ScenePositionObj), schafeObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum > 7 && randNum < 9)
            {
                var childobj = Instantiate(eggObj, new Vector3(2, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;

            }
            if (randNum == 10)
            {
                var childobj = Instantiate(eggObj, new Vector3(-2, 1, ScenePositionObj), eggObj.rotation);
                childobj.transform.parent = transform;

            }
            ScenePositionObj += 10;
        }
    




        if (ScenePositon < 1000)
        {



            var child = Instantiate(strecke, new Vector3(0, 0, ScenePositon), transform.rotation);
            child.transform.parent = transform;
            ScenePositon += 100f;

        }


    }
}

