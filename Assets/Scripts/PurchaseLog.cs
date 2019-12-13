using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoShekel;
    //public AudioSource playSound;
    public GameObject goy;
    public GameObject moneylander;
    public GameObject rabbi;
    public GameObject synagogue;
    public GameObject jewerly;
    public GameObject kibbutz;

    public void StartAutoShekel()
    {
        //playSound.Play();
        AutoShekel.SetActive(true);
        //GlobalShekels.ShekelCount -= GlobalJewerlyJew.jewerlyJewValue;
       //GlobalJewerlyJew.jewerlyJewValue *= 2;
        //GlobalJewerlyJew.turnOffJewerly = true;
        //GlobalJewerlyJew.jewerlyPerSec += 1;
       // GlobalJewerlyJew.numberOfJewerlyJews += 1;
    }
    public void BuyGoy ()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.goyCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.goyCost;
            GlobalUpgrades.goyCost *= 2;
            goy.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.goyCost);
            Autoclicker.moneyPerSec += 1;
        }
    }

    public void BuyMoneylander()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.moneylanderCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.moneylanderCost;
            GlobalUpgrades.moneylanderCost *= 2;
            moneylander.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.moneylanderCost);
            Autoclicker.moneyPerSec += 3;
        }
    }

    public void BuyRabbi()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.rabbiCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.rabbiCost;
            GlobalUpgrades.rabbiCost *= 2;
            rabbi.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.rabbiCost);
            Autoclicker.moneyPerSec += 10;
        }
    }

    public void BuySynagogue()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.synagogueCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.synagogueCost;
            GlobalUpgrades.synagogueCost *= 2;
            synagogue.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.synagogueCost);
            Autoclicker.moneyPerSec += 20;
        }
    }

    public void BuyJewerly()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.jewerlyCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.jewerlyCost;
            GlobalUpgrades.jewerlyCost *= 2;
            jewerly.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.jewerlyCost);
            Autoclicker.moneyPerSec += 30;
        }
    }

    public void BuyKibbutz()
    {
        if (GlobalShekels.ShekelCount >= GlobalUpgrades.kibbutzCost)
        {
            GlobalShekels.ShekelCount -= GlobalUpgrades.kibbutzCost;
            GlobalUpgrades.kibbutzCost *= 2;
            kibbutz.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.kibbutzCost);
            Autoclicker.moneyPerSec += 50;
        }
    }
}
