using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalUpgrades : MonoBehaviour
{
    public GameObject goy;
    public GameObject moneylander;
    public GameObject rabbi;
    public GameObject synagogue;
    public GameObject jewerly;
    public GameObject kibbutz;
    //public BigInt currentMoney = new BigInt();
    public static BigInt goyCost = new BigInt(25);
    public static BigInt moneylanderCost = new BigInt(100);
    public static BigInt rabbiCost = new BigInt(500);
    public static BigInt synagogueCost = new BigInt(1250);
    public static BigInt jewerlyCost = new BigInt(2000);
    public static BigInt kibbutzCost = new BigInt(5000);
        

    //public static int jewerlyJewValue = 25;
    // public static bool turnOffJewerly = false;
    //public GameObject jewerlyJewStats;
    //public static int numberOfJewerlyJews;
    //public static int jewerlyPerSec;
    // Update is called once per frame


    void Update()
    {
        if (AutoShekel.goyFlag)
            goy.SetActive(true);
        if (AutoShekel.moneylanderFlag)
            moneylander.SetActive(true);
        if (AutoShekel.rabbiFlag)
            rabbi.SetActive(true);
        if (AutoShekel.synagogueFlag)
            synagogue.SetActive(true);
        if (AutoShekel.jewerlyFlag)
            jewerly.SetActive(true);
        if (AutoShekel.kibbutzFlag)
            kibbutz.SetActive(true);

        //int goyCost = int.Parse(goy.transform.Find("Cost").GetComponent<Text>().text);
        //int moneylanderCost = int.Parse(moneylander.transform.Find("Cost").GetComponent<Text>().text);
        //int rabbiCost = int.Parse(rabbi.transform.Find("Cost").GetComponent<Text>().text);
        //int synagogueCost = int.Parse(synagogue.transform.Find("Cost").GetComponent<Text>().text);
        //int jewerlyCost = int.Parse(jewerly.transform.Find("Cost").GetComponent<Text>().text);
        //int kibbutzCost = int.Parse(kibbutz.transform.Find("Cost").GetComponent<Text>().text);
        //currentMoney = GlobalShekels.ShekelCount;
        //jewerlyJewStats.GetComponent<Text>().text = "Jewerly Jews: " + numberOfJewerlyJews + " @ " + jewerlyPerSec + " Per Second";
       // text.GetComponent<Text>().text = "Buy Jewerly Jew - " + jewerlyJewValue;
    }
}
