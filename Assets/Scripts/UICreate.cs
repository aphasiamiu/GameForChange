using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICreate : MonoBehaviour {
    float t;
    public GameObject prefab1;
    public GameObject prefab2;
    // Use this for initialization
    void Start () {
        t = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - t >= 2)
        {
            t = Time.time;
            Instantiate(prefab1, new Vector3(-8, -6,1), Quaternion.identity);
            Instantiate(prefab2, new Vector3(8, -6, 1), Quaternion.identity);
        }

    }
}
