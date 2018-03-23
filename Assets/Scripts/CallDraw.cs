﻿using UnityEngine;
using System.Collections;

public class CallDraw : MonoBehaviour {
    public PieChartMesh pie;
    /// <summary>
    /// The Data that represent per chart size
    /// </summary>
    public float[] mData;
    float t,a,b;
    public float mRotationAngle;
    public float mRadius;
    // Use this for initialization
    void Start()
    {
        t = Time.time;
        mData[0] = 10;
        mData[1] = 90;
        mData[2] = 0 ;
    }
    void FixedUpdate () {
        if (Time.time - t >= 2 && mData[1]>10)
        {
            t = Time.time;
            a = 5;
           // b = Random.Range(0.0f, 10.0f);
            mData[0] += a;
            mData[1] -= a;
            mData[2] = 0;
            // Debug.Log(t);
        }
        pie.Init(mData,100,mRotationAngle,mRadius);
        pie.Draw();
	}
}
