using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Application.LoadLevel("video1");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Application.LoadLevel("programming");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Application.LoadLevel("video2");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Application.LoadLevel("phase3BigScreen");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Application.LoadLevel("video3");
        }
    }
}
