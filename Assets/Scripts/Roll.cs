﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Roll : MonoBehaviour {
    
    public GameObject name;
    public int current;
    float t = Time.time;
  
    void Start()
    {
        name = gameObject;
        current = int.Parse(transform.parent.name) - 1;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Time.time - t > 3) {
            t = Time.time;
           
            if (ReadSelectedUser.Instance.sortnames.Count > current) {
                name.transform.parent.Find("bar").gameObject.SetActive(true);
                name.transform.parent.Find("Score_background").gameObject.SetActive(true);
                name.transform.parent.Find("Ranking_background").gameObject.SetActive(true);
                name.GetComponent<Text>().text = ReadSelectedUser.Instance.sortnames[current];
                name.transform.parent.Find("score").GetComponent<Text>().text = ReadSelectedUser.Instance.sortpoints[current].ToString();
                name.transform.parent.Find("Ranking").GetComponent<Text>().text = (current + 1).ToString();
                float max = (float)ReadSelectedUser.Instance.sortpoints[0];
                float now = (float)ReadSelectedUser.Instance.sortpoints[current];
                name.transform.parent.Find("bar").transform.localScale = new Vector3(now / max, 1.0F, 0);
                current = current + 9;
            }
            else
            {
                if ( int.Parse(transform.parent.name)-4<(ReadSelectedUser.Instance.sortnames.Count-3)%9) {
                    current = int.Parse(transform.parent.name) - 1;
                    name.GetComponent<Text>().text = ReadSelectedUser.Instance.sortnames[current];
                    name.transform.parent.Find("score").GetComponent<Text>().text = ReadSelectedUser.Instance.sortpoints[current].ToString();
                    name.transform.parent.Find("Ranking").GetComponent<Text>().text = (current + 1).ToString();
                    float max = (float)ReadSelectedUser.Instance.sortpoints[0];
                    float now = (float)ReadSelectedUser.Instance.sortpoints[current];
                    name.transform.parent.Find("bar").transform.localScale = new Vector3(now / max, 1.0F, 0);
                    current = current + 9;
                }
                else { 
                //name.transform.parent.parent.gameObject.SetActive(false);
                name.transform.parent.Find("bar").gameObject.SetActive(false);
                name.transform.parent.Find("Score_background").gameObject.SetActive(false);
                name.transform.parent.Find("Ranking_background").gameObject.SetActive(false);
                
                name.GetComponent<Text>().text = "";
                name.transform.parent.Find("score").GetComponent<Text>().text = "";
                name.transform.parent.Find("Ranking").GetComponent<Text>().text = "";
                current = int.Parse(transform.parent.name) - 1;
                }
            }
          
           

        }

    }
   
}
