using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diversity : MonoBehaviour {
    public Material m1;
    public Material m2;
 
    // Use this for initialization
    void Start () {
        int i = Random.Range(0, 100);
        if (i % 2 == 1) { GetComponent<Renderer>().material = m1; }

        if (i % 2 != 1) { GetComponent<Renderer>().material = m2; }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
