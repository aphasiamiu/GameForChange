using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour {
    
    float t;
    // Use this for initialization
    void Start () {
        t = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float TranslateSpeed = 0.025f;

        
        this.transform.Translate(Vector3.up * TranslateSpeed);

    }
}
