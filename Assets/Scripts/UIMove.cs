using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour {
    public GameObject cube;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        cube.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
