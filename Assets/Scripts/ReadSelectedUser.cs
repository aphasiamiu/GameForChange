using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class ReadSelectedUser : MonoBehaviour
{

    public GameObject text;
    private int startNum;
    private int count;
    private bool startflag;
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
            UnityWebRequest r = UnityWebRequest.Get("http://objection-1994.appspot.com/unity-read");
            yield return r.Send();

            var N = JSONObject.Parse(r.downloadHandler.text);
            if (!startflag)
            {
                string userNum = N["selectedNum"];
                startNum = int.Parse(userNum);
                startflag = true;
            }
            else
            {
                count = int.Parse(N["selectedNum"]) - startNum;
                if (text != null)
                    text.GetComponent<Text>().text = count.ToString();
            }

            print(startNum);
            print(count);
            yield return new WaitForSeconds(2);
        }
    }
}