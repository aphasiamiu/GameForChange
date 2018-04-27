using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateBar : MonoBehaviour {
    public GameObject bar;
    public GameObject bossBar;

    public int barNum;
    public float barWidth;

    public List<GameObject> barList;
    public List<GameObject> tagNameList;
    public List<GameObject> scoreList;
    public float maxHeight;

    private bool flag=false;
    private GameObject textCanvas;
    // Use this for initialization
    private void Awake()
    {
        maxHeight = bar.GetComponent<part>().bar_img.GetComponent<RectTransform>().rect.height;
    }
    void Start () {
        barList = new List<GameObject>();
        tagNameList = new List<GameObject>();
        scoreList = new List<GameObject>();
        barWidth = bar.GetComponent<part>().bar_img.GetComponent<RectTransform>().rect.width;
        textCanvas = GameObject.FindGameObjectWithTag("TextCanvas");
        float width = this.transform.parent.GetComponent<RectTransform>().rect.width;
        float interval = (width - (barNum * barWidth)) / (barNum + 1);
        for (int i = 0; i < barNum; i++)
        {
            GameObject newBar;
            if (i==0)
            {
                newBar = Instantiate(bossBar);
            }
            else
            {
                newBar = Instantiate(bar);
            }
            newBar.transform.parent = textCanvas.transform;
            Vector3 tempPos;
            tempPos.x = -width/2 + interval * (i + 1) + barWidth * i + barWidth / 2;
            tempPos.y = 0;
            tempPos.z = 0;
            newBar.transform.localPosition = tempPos;
            Vector3 tempScale;
            tempScale.x = 1;
            tempScale.y = 1;
            tempScale.z = 1;
            newBar.transform.localScale = tempScale;
            barList.Add(newBar.GetComponent<part>().bar_img);
            tagNameList.Add(newBar.GetComponent<part>().tag_text);
            scoreList.Add(newBar.GetComponent<part>().score_text);
        }
       /* for (int i = 0; i < barNum; i++)
        {
            GameObject newText = Instantiate(tagName);
            newText.transform.parent = textCanvas.transform;
            Vector3 tempPos;
            tempPos.x = barList[i].transform.localPosition.x;
            tempPos.y = 0;
            tempPos.z = 0;
            tempPos.y = -maxHeight/2 - 25;
            tempPos.x += barWidth/2 ;
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
        for (int i = 0; i < barNum; i++)
        {
            GameObject newScore = Instantiate(score);
            newScore.transform.parent = textCanvas.transform;
            Vector3 tempPos;
            tempPos.x = barList[i].transform.localPosition.x;
            tempPos.y = 0;
            tempPos.z = 0;
            tempPos.y = -maxHeight / 2 + 5;
            tempPos.x += barWidth / 4 *3;
            newScore.transform.localPosition = tempPos;
            Vector3 tempScale;
            tempScale.x = barWidth;
            tempScale.y = 0;
            tempScale.z = 0;
            tempScale.x = 1;
            tempScale.y = 1;
            newScore.transform.localScale = tempScale;
            newScore.transform.SetParent(barList[i].transform);
            scoreList.Add(newScore);
        }*/

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
        for(int i = 1; i < barNum; i++)
        {
            tagNameList[i].GetComponent<Text>().text = readData.Instance.hashtags[i];
        }
        tagNameList[0].GetComponent<Text>().text = "AvoidTopic";
    }
}
