using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour {
    public static bar Instance;
    public double cap=0;
    public double transratio = 0.01;
    public double heartratio = 6.0;
    public GameObject Bar;
    public int max = 0;
	// Use this for initialization
	void Start () {
		
	}
   

    // Update is called once per frame
    void Update () {
        max = ReadSelectedUser.Instance.hashpoints[0];
        for (int i = 0;i < ReadSelectedUser.Instance.hashpoints.Count;i++)
        {
            if (ReadSelectedUser.Instance.hashpoints[i]>max)
            {
                max = ReadSelectedUser.Instance.hashpoints[i];
            }
        }
       
        float TranslateSpeed = 0.005f;
        cap = 0.5 * transratio * ReadSelectedUser.Instance.sum * heartratio / 14.0;
        if(max>=cap & this.GetComponent<RectTransform>().localPosition.y >-600)
        {
            this.transform.Translate(Vector3.down * TranslateSpeed);
        }
        if(max<cap & this.GetComponent<RectTransform>().localPosition.y <0)
        { 
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
    }
}
