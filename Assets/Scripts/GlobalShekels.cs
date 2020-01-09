using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShekels : MonoBehaviour
{
    public static BigInt ShekelCount = new BigInt();
    public GameObject ShekelDisplay;
    public BigInt InternalShekel = new BigInt();

    void Update()
    {
        InternalShekel = ShekelCount;
        ShekelDisplay.GetComponent<Text>().text = "" + InternalShekel.showAsLetter();
    }
}
