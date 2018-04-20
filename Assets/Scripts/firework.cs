using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firework : MonoBehaviour {
    public float ti;
    public GameObject fire;
    
    // Use this for initialization
    void Start () {
        ti = Time.time;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - ti > 3)
        {
            ti = Time.time;
            fire.GetComponent<ParticleSystem>().Play();
        }
	}
}
