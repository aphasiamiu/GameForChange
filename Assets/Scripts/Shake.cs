using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {
    private bool startLerp = false;
    float t;
    public float amplitude = 1.0f;
    public float frequency = 0.1f;
    public float howlong = 1.0f;
    // Use this for initialization
    void Start () {
        shake();
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time-t>howlong)
        {
            amplitude = 0;
        }
	}

    void left()
    {
        this.transform.Translate(Vector3.left * amplitude);
    }
    void right()
    {
        this.transform.Translate(Vector3.right * amplitude);
    }
    void shake()
    {
        t = Time.time;
        InvokeRepeating("left", frequency, frequency);
        InvokeRepeating("right", frequency * 1.5f, frequency);
    }
}
