using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalJewerlyJew : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    public int currentMoney;
    public static int jewerlyJewValue = 25;
    public static bool turnOffJewerly = false;
    public GameObject jewerlyJewStats;
    public static int numberOfJewerlyJews;
    public static int jewerlyPerSec;
    // Update is called once per frame
    void Update()
    {
        currentMoney = GlobalShekels.ShekelCount;
        jewerlyJewStats.GetComponent<Text>().text = "Jewerly Jews: " + numberOfJewerlyJews + " @ " + jewerlyPerSec + " Per Second";
        text.GetComponent<Text>().text = "Buy Jewerly Jew - " + jewerlyJewValue;
        if (currentMoney >= jewerlyJewValue)
        {
            button.SetActive(true);
        }
        
        if (turnOffJewerly == true)
        {
            button.SetActive(false);
            turnOffJewerly = false;
        }
    }
}
