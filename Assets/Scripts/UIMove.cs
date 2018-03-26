using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour {
    
    float t=100000000.0f;
    int i = 0;
    int j = 0;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
           
        
        if (this.GetComponent<RectTransform>().localPosition.y>400 && i==0 && j==0) {
            
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 300);
            t = Time.time;
            j = 1;
        }
        if (Time.time - t > 1)
        {
            i = 1;
        }
        if (this.GetComponent<RectTransform>().localPosition.y <= 400 || i != 0)
        {
            float TranslateSpeed = 10.0f;
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }

        
    }
}
