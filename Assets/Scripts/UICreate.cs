using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UICreate : MonoBehaviour
{

    public GameObject prefab;
    public GameObject prefab2;
    GameObject pre;
    GameObject pre2;
    float t;
    void Start()
    {
        t = Time.time;
    }
    void Update()
    {
        if (Time.time - t > 1)
        {
            t = Time.time;
            pre = (GameObject)Instantiate(prefab);
            pre.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
            pre.GetComponent<RectTransform>().localPosition = new Vector3(1000, -550, 0);
            pre.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
            pre2 = (GameObject)Instantiate(prefab2);
            pre2.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
            pre2.GetComponent<RectTransform>().localPosition = new Vector3(-1000, -550, 0);
            pre2.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        }
    }

}