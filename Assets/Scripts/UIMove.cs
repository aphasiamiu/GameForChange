using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour {

    float t;
    int i = 0;
    int j = 0;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
           
        
        if (this.GetComponent<RectTransform>().localPosition.y>400) {
            
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(375, 250);
        }
        if (Time.time - t > 0.5)
        {
            i = i + 1;
            t = Time.time;
        }
        if (i % 2 != 1)
        {
            float TranslateSpeed = 8.3f;
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
        
    }
}
