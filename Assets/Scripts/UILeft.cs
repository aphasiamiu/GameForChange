using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILeft : MonoBehaviour {
    public Transform prefab;
    float t;
    // Use this for initialization
    void Start () {
        t = Time.time;
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - t >= 1)
        {
            t = Time.time;
            Instantiate(prefab, new Vector3(10,-6, -1), Quaternion.identity);
        }
    }
}
