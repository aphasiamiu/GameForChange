using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomName : MonoBehaviour {
    
    public GameObject name;

    void Start()
    {
        name = gameObject;   
    }
    // Update is called once per frame
    void Update () {

        name.GetComponent<Text>().text = ReadSelectedUser.Instance.names[int.Parse(transform.parent.name)];
        name.transform.parent.Find("score").GetComponent<Text>().text = ReadSelectedUser.Instance.points[int.Parse(transform.parent.name)].ToString();
    }

    //private void DisplayData()
    //{
    //    Debug.Log(ReadSelectedUser.Instance.names);
    //    Debug.Log(ReadSelectedUser.Instance.points);
    //}
}
