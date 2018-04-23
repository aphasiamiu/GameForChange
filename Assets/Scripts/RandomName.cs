using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomName : MonoBehaviour {
    
    public GameObject name;
    public float t;
    public AudioSource cheer0;
    public AudioSource cheer1;
    public AudioSource cheer2;
    
    void Start()
    {
        name = gameObject;
        t = Time.time;
    }
    // Update is called once per frame
    void Update () {
        if(Time.time - t > 1)
        {
            t = Time.time;
            if (name.transform.parent.Find("score").GetComponent<Text>().text!= ReadSelectedUser.Instance.sortpoints[int.Parse(transform.parent.name) - 1].ToString())
            {
                int r = Random.Range(0, 2);
                if (r == 0) { cheer0.Play(); }
                if (r == 1) { cheer1.Play(); }
                if (r == 2) { cheer2.Play(); }
                name.GetComponent<Text>().text = ReadSelectedUser.Instance.sortnames[int.Parse(transform.parent.name) - 1];
                name.transform.parent.Find("score").GetComponent<Text>().text = ReadSelectedUser.Instance.sortpoints[int.Parse(transform.parent.name) - 1].ToString();
            }
            
        }
        
    }
}
