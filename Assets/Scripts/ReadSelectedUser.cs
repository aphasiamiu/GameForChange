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
    public int k = 0;
    public double sum;
    public List<string> names = new List<string>();
    public List<int> points = new List<int>();
    public List<string> sortnames = new List<string>();
    public List<int> sortpoints = new List<int>();
    public List<string> scorenames = new List<string>();
    public List<int> scorepoints = new List<int>();
    public List<string> sortscorenames = new List<string>();
    public List<int> sortscorepoints = new List<int>();
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
            yield return r.SendWebRequest();
            
            var N = JSONObject.Parse(r.downloadHandler.text);

            /*Add new name,points to list*/
            if (N["names"].Count > 1)
            {
                if (i < N["names"].Count - 1)
                {
                    int tmp;
                    if (i == 0)
                    {
                        tmp = i;
                    }
                    else
                    {
                        tmp = i + 1;
                    }
                    for (int m = tmp; m < N["names"].Count; m++)
                    {
                        string name = N["names"][m];
                        names.Add(name);
                        sortnames.Add("");

                    }

                    for (int m = tmp; m < N["points"].Count; m++)
                    {
                        int point = N["points"][m];
                        sum += point;
                        points.Add(point);
                        sortpoints.Add(0);
                    }
                    i = N["names"].Count - 1;
                }
             /*   if (N["scorenames"].Count>0 && k < N["scorenames"].Count - 1)
                {
                    int tmp;
                    if (k == 0)
                    {
                        tmp = k;
                    }
                    else
                    {
                        tmp = k + 1;
                    }
                    for (int m = tmp; m < N["scorenames"].Count; m++)
                    {
                        string name = N["scorenames"][m];
                        scorenames.Add(name);
                        sortscorenames.Add("");
                    }

                    for (int m = tmp; m < N["scorepoints"].Count; m++)
                    {
                        int scorepoint = N["scorepoints"][m];
                        scorepoints.Add(scorepoint);
                        sortscorepoints.Add(0);
                    }
                    k = N["scorenames"].Count - 1;
                }
                */
                /*Add new hashtags.hashpoints to list*/
                if (j < N["hashtags"].Count - 1)
                {
                    int tmp;
                    if (j == 0)
                    {
                        tmp = j;
                    }
                    else
                    {
                        tmp = j + 1;
                    }
                    for (int m = tmp; m < N["hashtags"].Count; m++)
                    {
                        string hashtag = N["hashtags"][m];
                        hashtags.Add(hashtag);
                    }
                    for (int m = tmp; m < N["hashpoints"].Count; m++)
                    {
                        int hashpoint = N["hashpoints"][m];
                        hashpoints.Add(hashpoint);
                    }
                    j = N["hashtags"].Count - 1;
                }

                /*update data in the list */
                for (int m = 0; m <= j; m = m + 1)
                {
                    hashpoints[m] = N["hashpoints"][m];
                }
                for (int m = 0; m <= i; m = m + 1)
                {
                    names[m] = N["names"][m];
                    points[m] = N["points"][m];
                }
             /*   if (N["scorenames"].Count > 0)
                {
                    for (int m = 0; m <= k; m = m + 1)
                    {
                        scorenames[m] = N["scorenames"][m];
                        scorepoints[m] = N["scorepoints"][m];
                    }
                }*/
                readyStage = true;
                yield return new WaitForSeconds(3);
            }
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

            for (int i = 0; i < scorepoints.Count; i = i + 1)
            {
                sortscorenames[i] = scorenames[i];
                sortscorepoints[i] = scorepoints[i];
            }
            for (int i = 0; i < scorepoints.Count; i = i + 1)
            {
                for (int j = i + 1; j < scorepoints.Count; j = j + 1)
                {
                    if (sortscorepoints[i] < sortscorepoints[j])
                    {
                        int tmp = sortscorepoints[j];
                        sortscorepoints[j] = sortscorepoints[i];
                        sortscorepoints[i] = tmp;
                        string tmp2 = sortscorenames[j];
                        sortscorenames[j] = sortscorenames[i];
                        sortscorenames[i] = tmp2;
                    }
                }
            }
        }

      
    }
       
}