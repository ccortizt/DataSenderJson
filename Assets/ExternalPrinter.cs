using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalPrinter : MonoBehaviour
{

    public void PrintData()
    {
        //GameObject.FindGameObjectWithTag("GameController").GetComponent<SampleCollectionData>().Print();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<SampleCollectionData>().Translate();
    }
}
