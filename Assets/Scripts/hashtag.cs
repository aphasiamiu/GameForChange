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
    private int currentFontSize = 10;
    private int prevFontSize = 10;
    private float lerptime = 3;
    private bool startLerp = false;
    private float lerp = 0f;
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
            int fs = (int)(minfont + Mathf.Sqrt(currentVal) / 7);
            if(fs != currentFontSize)
            {
                prevFontSize = currentFontSize;
                currentFontSize = fs;
                startLerp = true;
            }
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
       if(startLerp)
        {
            lerp += Time.deltaTime / 2;
            this.tag.fontSize = (int)Mathf.Lerp(prevFontSize,currentFontSize, lerp);
        }
       if(prevFontSize==currentFontSize)
        {
            startLerp = false;
            lerp = 0;
        }
        
	}
}
