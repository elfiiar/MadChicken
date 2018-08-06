using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strecken : MonoBehaviour {
    public Transform strecke;
    public float ScenePositon = 9;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (ScenePositon < 100)
        {
            var child = Instantiate(strecke, new Vector3(0, 0, ScenePositon), transform.rotation);
            child.transform.parent = transform;
            ScenePositon += 1.4f;

        }


	}
}
