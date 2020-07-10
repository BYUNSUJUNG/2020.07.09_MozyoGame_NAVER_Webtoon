using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FindPan : MonoBehaviour
{
	public GameObject[] obj = new GameObject[12];
     

    void Start()
    {
        
        System.Random r = new System.Random();
        for (int i = 0; i < 12; i++)
        {
            obj[i].transform.position = new Vector3 (r.Next(100, 900), r.Next(300, 800), 0);
        }
    }

    void Update()
    {
        
    }
}
