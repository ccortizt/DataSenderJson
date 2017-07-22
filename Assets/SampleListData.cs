using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleListData : MonoBehaviour
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

    List<SampleData> samples;
    void Start()
    {
        samples = new List<SampleData>();
    }

    public void AddDataToList(SampleData sd)
    {
        samples.Add(sd);
    }

    public void Print()
    {
        foreach (var item in samples)
        {
            Debug.Log(item.p1 + " " + item.p2 + " " + item.p3);
        }
    }

    public void Translate()
    {
        //string jsonString = JsonHelper.arrayToJson<SampleData>();
    }
}
