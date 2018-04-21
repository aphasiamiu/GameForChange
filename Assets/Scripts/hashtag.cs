using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hashtag : MonoBehaviour {
    public Text tag;
    public float t;
    public int maxfont = 100;
    public int minfont = 10;
    // Use this for initialization
    void Start () {
        t = Time.time;
	}
    private void FixedUpdate()
    {
        tag.GetComponent<Text>().text = ReadSelectedUser.Instance.hashtags[int.Parse(transform.parent.name) - 1];
        if (Time.time - t > 0.1)
        {
            t = Time.time;
            int i = Random.Range(-10, 10);
            float m = 1.0f;
            for (int p = 0; p < ReadSelectedUser.Instance.hashpoints[int.Parse(transform.parent.name) - 1] / 10000; p++)
            {
                m = m * 1.05f;
            }
            // this.tag.fontSize = 10 * (int)m;
            this.tag.fontSize = 10 * ReadSelectedUser.Instance.hashpoints[int.Parse(transform.parent.name) - 1] / 10000;
            //this.tag.fontSize = 50;
            //this.tag.fontSize =10 * ReadSelectedUser.Instance.hashpoints[int.Parse(transform.parent.name) - 1] / 1000;
            //this.tag.fontSize = 100;
            if (this.tag.fontSize > maxfont)
            {
                this.tag.fontSize = maxfont;
            }
            if (this.tag.fontSize < minfont)
            {
                this.tag.fontSize = minfont;
            }
        }
    }
    // Update is called once per frame
    void Update() {
       
        
	}
}
