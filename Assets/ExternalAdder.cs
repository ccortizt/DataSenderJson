using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalAdder : MonoBehaviour
{

    int index;
    void Start()
    {
        index = 0;
    }
    public void AddNewData()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<SampleCollectionData>().AddDataToList(new SampleData(new Vector2(1, 2)), index);
        index++;
    }

}
