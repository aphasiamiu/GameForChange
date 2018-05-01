using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour {
    public AudioSource a;
    public VideoPlayer v;
    public bool flag;
	// Use this for initialization
	void Start () {
        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && flag == false)
        {
            a.Play();
            v.Play();
            flag = true;
        }
        //if(Input.GetKeyDown("space") && flag == true)
        //{
        //    a.Pause();
        //    v.Pause();
        //    flag = false;
        //}
    }
}
