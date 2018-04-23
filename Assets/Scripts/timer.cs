using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public static timer Instance;
    public float t;
    public int all = 300;
    public int min;
    public int sec;
    public GameObject time;
    public AudioSource clock;
    public bool flag;
    // Use this for initialization
    void Start () {
        flag = false;
        t = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time - t > 1)
        {
            t = Time.time;
            all = all - 1;
            if (all <= 0)
            {
                all = 0;
            }
            min = all / 60;
            sec = all % 60;
        }
        if (sec >= 10)
        { time.GetComponent<Text>().text = min.ToString() + ":" + sec.ToString(); }
        if (sec < 10) { time.GetComponent<Text>().text = min.ToString() + ":0" + sec.ToString(); }
        if (all < 30 && flag == false)
        {
            if(!clock.isPlaying)
            {
                clock.Play();
            }
            flag = true;
        }
        //time.GetComponent<Text>().text =Time.time.ToString();
    }
}
