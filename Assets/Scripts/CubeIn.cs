using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIn : MonoBehaviour {
    public float thrust; 
    public Rigidbody rb;
    float x, y, z,t;
    void Start()
    {   thrust = 20.0f;
        t = Time.time;
        rb = GetComponent<Rigidbody>();
        x = this.transform.localPosition.x;
        y = this.transform.localPosition.y;
        z = this.transform.localPosition.z;
        rb.AddForce(-this.transform.localPosition.x * thrust, -this.transform.localPosition.y * thrust, -this.transform.localPosition.z * thrust);
    }

    void Update()
    {
        if (Time.time - t > 1.4) {
        rb.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

    }
}
