using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShekel : MonoBehaviour
{

    public bool CreatingShekel = false;
    public static int ShekelIncrease = 0;
    public int InternalIncrease;
    public static bool goyFlag;
    public static bool moneylanderFlag;
    public static bool rabbiFlag;
    public static bool synagogueFlag;
    public static bool jewerlyFlag;
    public static bool kibbutzFlag;

    void Update()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.goyCost)
        {
            goyFlag = true;
        }
        //
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.moneylanderCost)
        {
            moneylanderFlag = true;
        }
        //
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.rabbiCost)
        {
            rabbiFlag = true;
        }
        //
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.synagogueCost)
        {
            synagogueFlag = true;
        }
        //
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.jewerlyCost)
        {
            jewerlyFlag = true;
        }
        //
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.kibbutzCost)
        {
            kibbutzFlag = true;
        }
        ShekelIncrease = Autoclicker.moneyPerSec;
        InternalIncrease = ShekelIncrease;
        if (CreatingShekel == false)
        {
            CreatingShekel = true;
            StartCoroutine(CreateTheShekel());
        }
    }

    IEnumerator CreateTheShekel()
    {
        GlobalShekels.ShekelCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingShekel = false; 
    }
}
