using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomResult : MonoBehaviour {
    public GameObject number;
	// Use this for initialization
	void Start () {
        int i = Random.Range(60, 100);
       
        number.GetComponent<Text>().text = i.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
