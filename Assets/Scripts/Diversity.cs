using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diversity : MonoBehaviour {
    public Material m1;
    public Material m2;
    public Material m3;
    public Material m4;

    // Use this for initialization
    void Start () {
        int i = Random.Range(0, 100);
        if (i % 4 == 1) { GetComponent<Renderer>().material = m1; }
        if (i % 4 == 2) { GetComponent<Renderer>().material = m2; }
        if (i % 4 == 3) { GetComponent<Renderer>().material = m3; }
        if (i % 4 == 0) { GetComponent<Renderer>().material = m4; }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
