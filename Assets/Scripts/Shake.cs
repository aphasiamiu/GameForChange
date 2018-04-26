using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {
    private bool startLerp = false;
    float t;
    public float amplitude = 0.1f;
    public float frequency = 0.1f;
    private float originPos;
    // Use this for initialization
    void Start () {
        originPos = this.transform.localPosition.x;
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    void left()
    {
        this.transform.Translate(Vector3.left * amplitude);
    }
    void right()
    {
        this.transform.Translate(Vector3.right * amplitude);
    }
    public void shake()
    {
        amplitude = 0.1f;
        InvokeRepeating("left", frequency, frequency);
        InvokeRepeating("right", frequency * 1.5f, frequency);
    }
    public void StopShake()
    {
        amplitude = 0;
        Vector3 tmpPos = this.transform.localPosition;
        if (tmpPos.x != originPos)
        {
            tmpPos.x = originPos;
            this.transform.localPosition = tmpPos;
        }
    }
}
