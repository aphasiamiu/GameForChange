using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hashtag : MonoBehaviour {
    public Text tag;
    public float t;
    public int maxfont = 100;
    public int minfont = 10;
    private float currentVal = 0;
    // Use this for initialization
    void Start () {
        t = Time.time;
	}
    private void FixedUpdate()
    {
        if (ReadSelectedUser.Instance.readyStage)
        {
            currentVal = ReadSelectedUser.Instance.hashpoints[int.Parse(transform.parent.name) - 1];
            tag.GetComponent<Text>().text = ReadSelectedUser.Instance.hashtags[int.Parse(transform.parent.name) - 1];
            this.tag.fontSize = (int)(minfont + Mathf.Sqrt(currentVal) / 15);
        }
        if(currentVal > hand.Instance.cap)
        {
            this.tag.color = Color.red;
        }
        else
        {
            this.tag.color = Color.blue;
        }
    }
    // Update is called once per frame
    void Update() {
       
        
	}
}
