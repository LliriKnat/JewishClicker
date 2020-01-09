using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShekel : MonoBehaviour
{

    public bool CreatingShekel = false;
    public static BigInt ShekelIncrease = new BigInt();
    public BigInt InternalIncrease = new BigInt();
    public static bool goyFlag;
    public static bool moneylanderFlag;
    public static bool rabbiFlag;
    public static bool synagogueFlag;
    public static bool jewerlyFlag;
    public static bool kibbutzFlag;
    private char compare;

    void Update()
    {
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.goyCost);
        if ((compare == '>') || (compare == '='))
        {
            goyFlag = true;
        }
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.moneylanderCost);
        if ((compare == '>') || (compare == '='))
        {
            moneylanderFlag = true;
        }
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.rabbiCost);
        if ((compare == '>') || (compare == '='))
        {
            rabbiFlag = true;
        }
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.synagogueCost);
        if ((compare == '>') || (compare == '='))
        {
            synagogueFlag = true;
        }
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.jewerlyCost);
        if ((compare == '>') || (compare == '='))
        {
            jewerlyFlag = true;
        }
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.kibbutzCost);
        if ((compare == '>') || (compare == '='))
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
        GlobalShekels.ShekelCount.plus(InternalIncrease);
        yield return new WaitForSeconds(1);
        CreatingShekel = false; 
    }
}
