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
    public bool readyStage=false;
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
    private bool startflag=false;

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
            /*Request to server for getting data*/
            UnityWebRequest r = UnityWebRequest.Get("http://etc-newscan-test.appspot.com/unity-read2");
            yield return r.Send();
            
            var N = JSONObject.Parse(r.downloadHandler.text);

            /*Add new name,points to list*/
            if (i < N["names"].Count-1)
            {
                for (int m = i; m < N["names"].Count; m++)
                {
                    string name = N["names"][m];
                    names.Add(name);
                    sortnames.Add("");

                }
                for (int m = i; m < N["points"].Count; m++)
                {
                    int point = N["points"][m];
                    sum += point;
                    points.Add(point);
                    sortpoints.Add(0);
                }
                i = N["names"].Count-1;
            }
            /*Add new hashtags.hashpoints to list*/
            if (j < N["hashtags"].Count-1)
            {
                for (int m = j; m < N["hashtags"].Count; m++)
                {
                    string hashtag = N["hashtags"][m];
                    hashtags.Add(hashtag);
                }
                for (int m = j; m < N["hashpoints"].Count; m++)
                {
                    int hashpoint = N["hashpoints"][m];
                    hashpoints.Add(hashpoint);
                }
                j = N["hashtags"].Count-1;
            }

            /*update data in the list */
            for (int m = 0; m <= j; m = m + 1)
            {
                hashpoints[m]= N["hashpoints"][m];
            }
            for (int m = 0; m <= i; m = m + 1)
            {
                names[m] = N["names"][m];
                points[m] = N["points"][m];
            }
            readyStage = true;
            yield return new WaitForSeconds(3);
        }
    }
    void Update()
    {
        if (Time.time - time > 0.5)
        {
            time = Time.time;
            for (int i = 0; i < points.Count; i = i + 1)
            {
                sortnames[i] = names[i];
                sortpoints[i] = points[i];
            }
            for (int i = 0; i < points.Count; i = i + 1)
            {
                for (int j = i+1; j < points.Count; j = j + 1)
                {
                    if(sortpoints[i]<sortpoints[j])
                    {
                        int tmp = sortpoints[j];
                        sortpoints[j] = sortpoints[i];
                        sortpoints[i] = tmp;
                        string tmp2 = sortnames[j];
                        sortnames[j] = sortnames[i];
                        sortnames[i] = tmp2;
                    }
                }
            }
            //sortpoints.Sort((x, y) => -x.CompareTo(y));
            //for (int i = 0; i < points.Count; i = i + 1)
            //{
            //    for (int j = 0; j < points.Count; j = j + 1)
            //        if (sortpoints[i] == points[j]){
            //        sortnames[i] = names[j];
            //    }
            //}

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
       
}