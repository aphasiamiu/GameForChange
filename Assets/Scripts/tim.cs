using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tim : MonoBehaviour {
    public float ti;
    public int r;
    public static tim Instance;
    // Use this for initialization
    void Start () {
        ti = Time.time;
        r = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - ti > 10)
        {
            ti = Time.time;
            r = r + 1;
        }
	}
}
