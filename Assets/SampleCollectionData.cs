using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCollectionData : MonoBehaviour
{
    private static bool exists;
    void Awake()
    {
        if (!exists)
        {
            exists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    SampleData[] samples;
    void Start()
    {
        samples = new SampleData[8];
    }

    public void AddDataToList(SampleData sd, int index)
    {
        Debug.Log(index);
        samples[index] = sd;
    }

    //public void Print()
    //{
    //    foreach (var item in samples)
    //    {
    //        Debug.Log(item.p1 + " " + item.p2 + " " + item.p3);
    //    }
    //}

    public void Translate()
    {
        string jsonString = JsonHelper.arrayToJson<SampleData>(samples);
        Debug.Log(jsonString);
    }
}
