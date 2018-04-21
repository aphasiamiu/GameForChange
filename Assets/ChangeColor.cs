using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour {
    private int count=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count++;
        if(count>=3)
        {
            this.GetComponent<Image>().color = Color.red;
        }
        if(count>=6)
        {
            this.GetComponent<Image>().color = Color.white;
            count = 0;
        }
	}
}
