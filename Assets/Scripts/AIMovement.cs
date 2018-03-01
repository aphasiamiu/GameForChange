﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public int size = 1;
    public Transform Cubepre;

    // Use this for initialization
    void Start()
    {
        float angle = 0.0f;
        float p = 3.141592653589793f;
        float step = 1.0f;

        for (int x = 0; x < 20; x++)
        {
            angle = angle + p / (10.0f);

            Instantiate(Cubepre, new Vector3(Mathf.Sin(angle) * 4, 0, Mathf.Cos(angle) * 4), Quaternion.identity);
            Instantiate(Cubepre, new Vector3(Mathf.Sin(angle) * 3, 0, Mathf.Cos(angle) * 3), Quaternion.identity);
            Instantiate(Cubepre, new Vector3(Mathf.Sin(angle) * 5, 0, Mathf.Cos(angle) * 2), Quaternion.identity);
        }
        angle = p / 15.0f;
        for (int x = 0; x < 20; x++)
        {
            angle = angle + p / (10.0f);

            Instantiate(Cubepre, new Vector3(Mathf.Sin(angle) * 9 / 2, 0, Mathf.Cos(angle) * 9 / 2), Quaternion.identity);

            Instantiate(Cubepre, new Vector3(Mathf.Sin(angle) * 7 / 2, 0, Mathf.Cos(angle) * 7 / 2), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
