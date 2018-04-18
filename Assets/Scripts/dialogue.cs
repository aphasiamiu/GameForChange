using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogue : MonoBehaviour {
    public GameObject finger;
    public GameObject talk;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (finger.GetComponent<RectTransform>().localPosition.y > 150)
        {
            talk.GetComponent<Text>().text = "Don't worry people, we're gonna take care of this.";
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= 150 & finger.GetComponent<RectTransform>().localPosition.y > 50)
        {
            talk.GetComponent<Text>().text = "I'm gonna protect this country and everything we love about it!";
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= 50 & finger.GetComponent<RectTransform>().localPosition.y > -50)
        {
            talk.GetComponent<Text>().text = "All of our enemies? BAM! Right off the map. Wouldn't that be nice?";
        }
        if (finger.GetComponent<RectTransform>().localPosition.y <= -50)
        {
            talk.GetComponent<Text>().text = "So get ready folks, this thing is gonna be HUGE!";
        }
    }
}
