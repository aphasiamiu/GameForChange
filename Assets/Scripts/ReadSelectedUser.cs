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
    public float time;
    public int i = 0;
    public int j = 0;
    public double sum;
    public List<string> names = new List<string>();
    public List<int> points = new List<int>();
    public List<string> sortnames = new List<string>();
    public List<int> sortpoints = new List<int>();
    public List<int> hashpoints = new List<int>();
    public List<string> hashtags = new List<string>();
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
        time = Time.time;
        startNum = 0;
        sum = 0;
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
            UnityWebRequest r = UnityWebRequest.Get("http://etc-newscan-test.appspot.com/unity-read2");
            yield return r.Send();
            
            var N = JSONObject.Parse(r.downloadHandler.text);
         
            string name = N["names"][i];
            int point = N["points"][i];
            string hashtag = N["hashtags"][j];
            int hashpoint = N["hashpoints"][j];
            
            if (!(name == null)) {
                sum += point;
                names.Add(name);
                points.Add(point);
                sortnames.Add("");
                sortpoints.Add(0);
                i = i + 1;
                //print(name);
                //print(point);
            }
            if (!(hashtag == null))
            {
                hashpoints.Add(hashpoint);
                hashtags.Add(hashtag);
                //sortnames.Add("");
                //sortpoints.Add(0);
                j = j + 1;
                //print(name);
                //print(point);
            }
            for (int j = 0; j < i; j = j + 1)
            {
                hashtags[j]= N["hashtags"][j];
                hashpoints[j]= N["hashpoints"][j];
            }
            for (int j = 0; j < i; j = j + 1)
            {
                names[j] = N["names"][j];
                points[j] = N["points"][j];
            }
            // yield return new WaitForSeconds(1);
        }
    }
    void Update()
    {
        if (Time.time - time > 1)
        {
            time = Time.time;
            StartCoroutine(GetText());
            for (int i = 0; i < points.Count; i = i + 1)
            {
                sortnames[i] = names[i];
                sortpoints[i] = points[i];
            }
            sortpoints.Sort((x, y) => -x.CompareTo(y));
            for (int i = 0; i < points.Count; i = i + 1)
            {
                for (int j = 0; j < points.Count; j = j + 1)
                    if (sortpoints[i] == points[j]){
                    sortnames[i] = names[j];
                }
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
       
}