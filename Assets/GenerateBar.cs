using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateBar : MonoBehaviour {
    public GameObject bar;
    public GameObject tagName;
    public int barNum;
    public float barWidth;
    public float heightMaxPercentage;
    public List<GameObject> barList;
    public List<GameObject> tagNameList;
    public float maxHeight;

    private bool flag=false;
    private GameObject textCanvas;
	// Use this for initialization
	void Start () {
        barList = new List<GameObject>();
        tagNameList = new List<GameObject>();
        textCanvas = GameObject.FindGameObjectWithTag("TextCanvas");
        float height = this.transform.parent.GetComponent<RectTransform>().rect.height;
        float width = this.transform.parent.GetComponent<RectTransform>().rect.width;
        float interval = (width - (barNum * barWidth)) / (barNum + 1);
        maxHeight = heightMaxPercentage * height;
        for (int i = 0; i < barNum; i++)
        {
            GameObject newBar = Instantiate(bar);
            newBar.transform.parent = this.transform.parent;
            Vector3 tempPos;
            tempPos.x = -width/2 + interval * (i + 1) + barWidth * i + barWidth / 2;
            tempPos.y = 0;
            tempPos.z = 0;
            newBar.transform.localPosition = tempPos;
            Vector3 tempScale;
            tempScale.x = barWidth;
            tempScale.y = maxHeight;
            tempScale.z = 0;
            newBar.transform.localScale = tempScale;
            barList.Add(newBar);

        }
        for (int i = 0; i < barNum; i++)
        {
            GameObject newText = Instantiate(tagName);
            newText.transform.parent = textCanvas.transform;
            Vector3 tempPos;
            tempPos.x = barList[i].transform.localPosition.x;
            tempPos.y = 0;
            tempPos.z = 0;
            tempPos.y = -maxHeight/2 - 15;
            tempPos.x += barWidth / 2 ;
            newText.transform.localPosition = tempPos;
            Vector3 tempScale;
            tempScale.x = barWidth;
            tempScale.y = 0;
            tempScale.z = 0;
            tempScale.x = 1;
            tempScale.y = 1;
            newText.transform.localScale = tempScale;
            tagNameList.Add(newText);
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(!flag&&readData.Instance.readyStage)
        {
            flag = true;
            loadDataAndTag();
        }
	}
    public void loadDataAndTag()
    {
        for(int i = 0; i < barNum; i++)
        {
            tagNameList[i].GetComponent<Text>().text = readData.Instance.hashtags[i];
        }
    }
}
