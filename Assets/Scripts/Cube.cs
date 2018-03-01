using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public float thrust; 
    public Rigidbody rb;
    void Start()
    {   thrust = 10.0f;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z);
    }
}
