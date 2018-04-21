using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class dialogue : MonoBehaviour {
    public GameObject finger;
    public GameObject talk;
    public List<string> dialog;
    public List<string> tags;
    private Dictionary<string, string> _dialogDic;
    public List<bool> _flags;
    public bool flag = false;
    // Use this for initialization
    void Start () {
        _flags = new List<bool>();
        for(int i=0;i<4;i++)
        {
            _flags.Add(false);
        }
        if (dialog.Count==tags.Count)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                _dialogDic.Add(tags[i], dialog[i]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        for(int i = 0; i<ReadSelectedUser.Instance.hashtags.Count; i = i + 1)
        {
            tags[i] = ReadSelectedUser.Instance.hashtags[i];
        }
        if (ReadSelectedUser.Instance.hashpoints[0] > hand.Instance.cap)
        {
            talk.GetComponent<Text>().text = ReadSelectedUser.Instance.hashtags[0];
        }
        if (finger.GetComponent<RectTransform>().localPosition.y > 100 &&!_flags[0])
        {
            talk.GetComponent<Text>().text = "Don't worry people, we're gonna take care of this.";
            _flags[0] = true;
            setFalseExcept(0);
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= 100 & finger.GetComponent<RectTransform>().localPosition.y > 0 && !_flags[1])
        {
            _flags[1] = true;
            setFalseExcept(1);
            talk.GetComponent<Text>().text = "I'm gonna protect this country and everything we love about it!";
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= 0 & finger.GetComponent<RectTransform>().localPosition.y > -70 && !_flags[2])
        {
            _flags[2] = true;
            setFalseExcept(2);
            talk.GetComponent<Text>().text = "All of our enemies? BAM! Right off the map. Wouldn't that be nice?";
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= -70 && !_flags[3])
        {
            _flags[3] = true;
            setFalseExcept(3);
            talk.GetComponent<Text>().text = "So get ready folks, this thing is gonna be HUGE!";
        }
    }
    private void setFalseExcept(int index)
    {
        for (int i = 0; i < 4; i++)
        {
            if(i== index)
            {
                continue;
            }
            _flags[i]=false;
        }
    }
   
}
