using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class color : MonoBehaviour {
    public GameObject Bar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Bar.GetComponent<RectTransform>().localPosition.y < 0)
        {
            this.GetComponent<Image>().color = Color.red;
        }
        if (Bar.GetComponent<RectTransform>().localPosition.y < -200) {
            this.GetComponent<Image>().color = Color.blue;
        }
        if (Bar.GetComponent<RectTransform>().localPosition.y < -400)
        {
            this.GetComponent<Image>().color = Color.black;
        }
    }
}
