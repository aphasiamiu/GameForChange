using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
    public static hand Instance;
    public double cap=0;
    public double transratio = 0.01;
    public double heartratio = 6.0;
    public GameObject finger;
    public int max = 0;
	// Use this for initialization
	void Start () {
		
	}
    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // Update is called once per frame
    void Update () {
        for(int i = 0;i < ReadSelectedUser.Instance.hashpoints.Count;i++)
        {
            if (ReadSelectedUser.Instance.hashpoints[i]>max)
            {
                max = ReadSelectedUser.Instance.hashpoints[i];
            }
        }
       
        float TranslateSpeed = 0.1f;
        cap = 0.5 * transratio * ReadSelectedUser.Instance.sum * heartratio / 14.0;
        if(max<=cap & this.GetComponent<RectTransform>().localPosition.y >-100)
        {
            this.transform.Translate(Vector3.down * TranslateSpeed);
        }
        if(max>cap & this.GetComponent<RectTransform>().localPosition.y <170)
        { 
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
    }
}
