﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {

        }

        if(Input.touchCount > 0)
        {
            Debug.Log(Input.GetTouch(0).position);
        }
    }
}
