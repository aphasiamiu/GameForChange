using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public float t;
    public int all = 300;
    public int min;
    public int sec;
    public GameObject time;
    // Use this for initialization
    void Start () {
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

        time.GetComponent<Text>().text = min.ToString() + ":"+ sec.ToString();
    }
}
