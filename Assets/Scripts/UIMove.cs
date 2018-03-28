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
        if (this.GetComponent<RectTransform>().localPosition.y > 680)
        {
            Destroy(this.gameObject);
        }

        if (this.GetComponent<RectTransform>().localPosition.y>450) {
            
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(480, 320);
        }
        if (Time.time - t > 0.5)
        {
            i = i + 1;
            t = Time.time;
        }
        if (i % 2 != 1)
        {
            float TranslateSpeed = 6.5f;
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
        
    }
}
