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
	
	// Update is called once per frame
	void Update() {
        tag.GetComponent<Text>().text = ReadSelectedUser.Instance.hashtags[int.Parse(transform.parent.name) - 1];
        if (Time.time - t > 1)
        {
            t = Time.time;
            int i = Random.Range(-10, 10);
            //this.tag.fontSize += (ReadSelectedUser.Instance.hashpoints[int.Parse(transform.parent.name) - 1]);
            this.tag.fontSize += i;
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
}
