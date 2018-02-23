using UnityEngine;
using System.Collections;

public class CallDraw : MonoBehaviour {
    public PieChartMesh pie;
    /// <summary>
    /// The Data that represent per chart size
    /// </summary>
    public float[] mData;
    
    public float mRotationAngle;
    public float mRadius;
	// Use this for initialization
	void FixedUpdate () {
        pie.Init(mData,100,mRotationAngle,mRadius);
        pie.Draw();
	}
}
