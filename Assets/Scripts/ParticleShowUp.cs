using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleShowUp : MonoBehaviour
{
    
    public ParticleSystem pop;
    float t;
    // Use this for initialization
    void Start()
    {
        
        pop.Play();
        t = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(t>0 && Time.time - t > 1)
        {
            pop.Stop();
        }

    }
}