using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SampleData
{

    public float p1;
    public float p2;
    public float p3;


    public SampleData(Vector2 v)
    {
        p1 = UnityEngine.Random.Range(1, 100);
        p2 = UnityEngine.Random.Range(1, 100);
        p3 = UnityEngine.Random.Range(1, 100);
    }

}
