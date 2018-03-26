using UnityEngine;
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
        mData[0] = 50;
        mData[1] = 50;
        mData[2] = 0 ;
    }
    void FixedUpdate () {
        if (Time.time - t >= 2)
        {
            t = Time.time;
            a = Random.Range(0.0f, 10.0f);
            mData[0] += (a-5);
            mData[1] -= (a-5);
            mData[2] = 0;
            if (mData[0] <= 0)
            {
                mData[0] = 1;
                mData[1] = 99;
            }
            if (mData[1] <= 0)
            {
                mData[1] = 1;
                mData[0] = 99;
            }
            // Debug.Log(t);
        }
        pie.Init(mData,100,mRotationAngle,mRadius);
        pie.Draw();
	}
}
