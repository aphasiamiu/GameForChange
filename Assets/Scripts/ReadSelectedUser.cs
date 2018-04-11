using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class ReadSelectedUser : MonoBehaviour
{
    public static ReadSelectedUser Instance;

    public int i = 0;
    public List<string> names = new List<string>();
    public List<int> points = new List<int>();
    public GameObject text;
    private int startNum;
    private int count;
    private bool startflag;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    // Use this for initialization
    void Start()
    {
        startNum = 0;
        count = 0;
        startflag = false;
        StartCoroutine(GetText());
    }

    IEnumerator SendPost(string _url, WWWForm _wform)
    {
        WWW postData = new WWW(_url, _wform);
        yield return postData;
    }

    IEnumerator GetText()
    {
        while (true)
        {
            UnityWebRequest r = UnityWebRequest.Get("https://etc-newscan.appspot.com/unity-read2");
            yield return r.Send();
            
            var N = JSONObject.Parse(r.downloadHandler.text);
         
            string name = N["names"][i];
            int point = N["points"][i];
            i = i + 1;
            if (point != 0) {
                names.Add(name);
                points.Add(point);
                print(name);
                print(point);
            }
           
            //yield return new WaitForSeconds(1);
        }
    }
    public void FixedUpdate()
    {
        for(int j = 0;j < points.Count; j = j + 1)
        {
            for (int k = j; k < names.Count; k = k + 1)
            {
                if (points[k] > points[j])
                {
                    int tmp = points[k];
                    points[k] = points[j];
                    points[j] = tmp;
                    string tmps = names[k];
                    names[k] = names[j];
                    names[j] = tmps;
                }
            }
        }
    }
}