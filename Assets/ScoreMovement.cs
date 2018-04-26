using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMovement : MonoBehaviour {

    private int prevScore;
    private int targetScore;
    private float duration;
    private bool flag = false;
    public bool getCap = false;
    private float lerp = 0;
    private Color originColor;
    // Use this for initialization
    void Start()
    {
        originColor = this.GetComponent<Text>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            if (targetScore < prevScore)
            {
                //Lose point
                this.GetComponent<Text>().color = Color.red;
            }
            else
            {
                //Gain point
                this.GetComponent<Text>().color = Color.green;
            }
            lerp += Time.deltaTime / 2;
            this.GetComponent<Text>().text = ((int)Mathf.Lerp(prevScore, targetScore, lerp)).ToString();
            if(this.GetComponent<Text>().text == targetScore.ToString())
            {
                flag = false;
                this.GetComponent<Text>().color = originColor;
                lerp = 0;
            }
        }
    }
    public void startChangeScore(int oriScore, int tarScore, float dura)
    {
        prevScore = oriScore;
        targetScore = tarScore;
        duration = dura;
        flag = true;
    }
}
