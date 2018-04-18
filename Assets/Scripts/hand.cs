using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
    public GameObject finger;
    public int max = 0;
	// Use this for initialization
	void Start () {
		
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
        if(max<150000)
        {
            this.transform.Translate(Vector3.down * TranslateSpeed);
        }
        if (max > 300000)
        { 
            this.transform.Translate(Vector3.up * TranslateSpeed);
        }
    }
}
