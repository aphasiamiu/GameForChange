using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UICreate : MonoBehaviour
{

    public GameObject rank;
    
    float t;
    void Start()
    {
        if (ReadSelectedUser.Instance.sortnames.Count != 0) {
            for (int i = 0; i < ReadSelectedUser.Instance.sortnames.Count; i++)
            {
                GameObject r = Instantiate(rank);
                r.transform.SetParent(GameObject.FindGameObjectWithTag("Scoreboard_Backtround").transform);
                r.GetComponent<RectTransform>().localPosition = new Vector3(0,i*100,0);
            }
        }
        //for (int i = 0; i < 100; i++)
        //{
        //    pre = (GameObject)Instantiate(prefab);
        //    pre.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        //    pre.GetComponent<RectTransform>().localPosition = new Vector3(1000, 525 - 220 * i, 0);
        //    pre.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        //    pre2 = (GameObject)Instantiate(prefab2);
        //    pre2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        //    pre2.GetComponent<RectTransform>().localPosition = new Vector3(-1000, 525 - 220 * i, 0);
        //    pre2.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        //}
    }
    void Update()
    {
        //if (Time.time - t > 1)
        //{
        //    t = Time.time;
        //    pre = (GameObject)Instantiate(prefab);
        //    pre.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        //    pre.GetComponent<RectTransform>().localPosition = new Vector3(1000, -550, 0);
        //    pre.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        //    pre2 = (GameObject)Instantiate(prefab2);
        //    pre2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        //    pre2.GetComponent<RectTransform>().localPosition = new Vector3(-1000, -550, 0);
        //    pre2.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        //}
       
    }

}