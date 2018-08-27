using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour
{

    //Zäune sind aus dem AssetStore: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-nature-pack-52670
    //FloorMaterial ist aus dem Internet: https://i.pinimg.com/736x/d3/7e/b5/d37eb53f257e3fe43c52829f1a3c2a9b--hand-painted-textures-d-texture.jpg
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
           // Debug.Log("strecke erweitert");
        } 
        else if(z % 100 != 0)
        {
            setOnlyOneTime = true;
        }
    }
}

