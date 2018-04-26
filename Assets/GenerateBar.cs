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
	// Use this for initialization
	void Start () {
        barList = new List<GameObject>();
        tagNameList = new List<GameObject>();
        float height = this.transform.parent.GetComponent<RectTransform>().rect.height;
        float width = this.transform.parent.GetComponent<RectTransform>().rect.width;
        float interval = (width - (barNum * barWidth)) / (barNum + 1);
        maxHeight = heightMaxPercentage * height;
        for (int i = 0; i < barNum; i++)
        {
            GameObject newBar = Instantiate(bar);
            GameObject newText = Instantiate(tagName);
            newBar.transform.parent = this.transform.parent;
            newText.transform.parent = this.transform.parent;
            Vector3 tempPos;
            tempPos.x = -width/2 + interval * (i + 1) + barWidth * i + barWidth / 2;
            tempPos.y = 0;
            tempPos.z = 0;
            newBar.transform.localPosition = tempPos;
            tempPos.y = -250;
            tempPos.x += barWidth/2;
            newText.transform.localPosition = tempPos;
            Vector3 tempScale;
            tempScale.x = barWidth;
            tempScale.y = 0;
            tempScale.z = 0;
            newBar.transform.localScale = tempScale;
            tempScale.x = 1;
            tempScale.y = 1;
            newText.transform.localScale = tempScale;
            GameObject newGameObj = new GameObject(i.ToString());
            newGameObj.transform.parent = this.transform.parent;
            newGameObj.transform.position = Vector3.zero;
            newGameObj.transform.localScale = new Vector3(1, 1, 1);
            newBar.transform.parent = newGameObj.transform;
            newText.transform.parent = newGameObj.transform;
            barList.Add(newBar);
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
