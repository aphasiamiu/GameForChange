using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomName : MonoBehaviour {
    
    public GameObject name;
    public float t;

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
            name.GetComponent<Text>().text = ReadSelectedUser.Instance.sortnames[int.Parse(transform.parent.name) - 1];
            name.transform.parent.Find("score").GetComponent<Text>().text = ReadSelectedUser.Instance.sortpoints[int.Parse(transform.parent.name) - 1].ToString();
        }
        
    }

    //private void DisplayData()
    //{
    //    Debug.Log(ReadSelectedUser.Instance.names);
    //    Debug.Log(ReadSelectedUser.Instance.points);
    //}
}
