﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barMovement : MonoBehaviour {
    private Vector3 prevPos;
    private Vector3 targetPos;
    private float duration;
    private bool flag=false;
    public bool getCap = false;
    private float lerp=0;
    private Color originColor;
	// Use this for initialization
	void Start () {
        originColor = this.GetComponent<SpriteRenderer>().color;
    }
	
	// Update is called once per frame
	void Update () {
        if (flag&&(!getCap||targetPos.y>prevPos.y))
        {
            if(targetPos.y<prevPos.y)
            {
                //Lose point
                this.GetComponent<SpriteRenderer>().color = Color.red;
            }
            else
            {
                //Gain point
                this.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            Vector3 tempPos;
            tempPos = targetPos;
            lerp += Time.deltaTime/duration;
            tempPos.y = Mathf.Lerp(this.transform.localPosition.y, targetPos.y, lerp);
            this.transform.localPosition = tempPos;
            if(Mathf.Abs(this.transform.localPosition.y - targetPos.y)<0.5f)
            {
                this.GetComponent<SpriteRenderer>().color = originColor;
                this.transform.localPosition = targetPos;
                flag = false;
                lerp = 0;
                if(getCap)
                {
                    //Get to the Cap
                    this.GetComponent<SpriteRenderer>().color = Color.grey;
                }
            }
        }
    }
    public void startMove(Vector3 originPos, Vector3 taPos, float dura)
    {
        prevPos = originPos;
        targetPos = taPos;
        duration = dura;
        flag = true;
    }
}