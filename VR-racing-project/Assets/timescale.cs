using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timescale : MonoBehaviour
{
    public float activeTimescale = 1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = activeTimescale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
