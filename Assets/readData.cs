using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class readData : MonoBehaviour
{
    public static readData Instance;
    public bool readyStage = false;
    public float time;
    public int i = 0;
    public int j = 0;
    public double sum;
    public List<string> names = new List<string>();
    public List<int> points = new List<int>();

    public List<int> hashpoints = new List<int>();
    public List<string> hashtags = new List<string>();

    public List<GameObject> barList;
    public List<GameObject> tagList;
    public GameObject text;
    public float cap = 0;
    private int startNum;
    private int count;
    private bool startflag = false;
    private GameObject generator;

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
        generator = GameObject.FindGameObjectWithTag("Generator");
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
                    }

                    for (int m = tmp; m < N["points"].Count; m++)
                    {
                        int point = N["points"][m];
                        sum += point;
                        points.Add(point);
                    }
                    i = N["names"].Count - 1;
                }
               
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
               
                readyStage = true;
                yield return new WaitForSeconds(3);
            }
        }
    }
    void Update()
    {
        if(readyStage&&!startflag)
        {
            barList = generator.GetComponent<GenerateBar>().barList;
            tagList = generator.GetComponent<GenerateBar>().tagNameList;
            startflag = true;
            cap = (float)(0.5 * 0.05 * sum * 6 / 14.0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.LoadLevel("hashtag");
        }
        if(cap!=0)
        {
            refresh();
        }
    }
    public void refresh()
    {
        for (int i = 0; i < barList.Count; i++)
        {
            tagList[i].GetComponent<Text>().text = readData.Instance.hashtags[i];
            Vector3 tempLocalScale;
            tempLocalScale.x = barList[i].transform.localScale.x;
            tempLocalScale.y = ((float)hashpoints[i]) / cap * generator.GetComponent<GenerateBar>().maxHeight;
            tempLocalScale.z = 0;
            barList[i].transform.localScale = tempLocalScale;
        }
    }

}