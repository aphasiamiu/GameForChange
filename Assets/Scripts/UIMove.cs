using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMove : MonoBehaviour {
    public Text name;
    public Text score;
    public Text number;
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
        if (this.GetComponent<RectTransform>().localPosition.y > height - 900)
        {
            Destroy(this.gameObject);
        }

        if (this.GetComponent<RectTransform>().localPosition.y> height-1100) {
            
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(480, 320);
            this.name.fontSize = 60;
            Vector3 temp = this.name.transform.localPosition;
            temp.y = 40;
            this.name.transform.localPosition = temp;
            this.score.fontSize = 30;
            this.number.fontSize = 140;
            Vector3 temp2 = this.number.transform.localPosition;
            temp2.y = 20;
            this.number.transform.localPosition = temp2;

        }
        if (Time.time - t > 0.5)
        {
            i = i + 1;
            t = Time.time;
        }
        if (i % 2 != 1)
        {
            float TranslateSpeed = 7.5f;
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
        
    }
}
