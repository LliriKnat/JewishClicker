using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShekels : MonoBehaviour
{
    public static int ShekelCount;
    public GameObject ShekelDisplay;
    public int InternalShekel;

    void Update()
    {
        InternalShekel = ShekelCount;
        ShekelDisplay.GetComponent<Text>().text = "" + InternalShekel;
    }
}
