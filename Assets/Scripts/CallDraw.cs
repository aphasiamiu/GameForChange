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
        mData[0] = 0;
        mData[1] = 180;
        mData[2] = 0 ;
    }
    void FixedUpdate () {
        if (Time.time - t >= 1 && mData[1]>10)
        {
            t = Time.time;
            a = Random.Range(0.0f, 10.0f);
            b = Random.Range(0.0f, 10.0f);
            mData[0] += a;
            mData[2] += b;
            mData[1] = mData[1] - a - b;
            // Debug.Log(t);
        }
        pie.Init(mData,100,mRotationAngle,mRadius);
        pie.Draw();
	}
}
