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
        
        int height = Mathf.CeilToInt(Screen.height);
        int width = Mathf.CeilToInt(Screen.width);
        //if (this.GetComponent<RectTransform>().localPosition.y >height/2+100)
        //{
        //    Destroy(this.gameObject);
        //}

        if (this.GetComponent<RectTransform>().localPosition.y> height-800) {
            
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(480, 320);
        }
        if (Time.time - t > 0.5)
        {
            i = i + 1;
            t = Time.time;
        }
        if (i % 2 != 1)
        {
            float TranslateSpeed = 8.5f;
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
        
    }
}
