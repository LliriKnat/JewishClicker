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
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.goyCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.goyCost);
            GlobalUpgrades.goyCost.multiplySmall(2);
            goy.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.goyCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(1);
        }
    }

    public void BuyMoneylander()
    {
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.moneylanderCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.moneylanderCost);
            GlobalUpgrades.moneylanderCost.multiplySmall(2);
            moneylander.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.moneylanderCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(3);
        }
    }

    public void BuyRabbi()
    {
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.rabbiCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.rabbiCost);
            GlobalUpgrades.rabbiCost.multiplySmall(2);
            rabbi.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.rabbiCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(10);
        }
        StartCoroutine(ShopCooldown());
    }

    public void BuySynagogue()
    {
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.synagogueCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.synagogueCost);
            GlobalUpgrades.synagogueCost.multiplySmall(2);
            synagogue.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.synagogueCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(20);
        }
    }

    public void BuyJewerly()
    {
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.jewerlyCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.jewerlyCost);
            GlobalUpgrades.jewerlyCost.multiplySmall(2);
            jewerly.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.jewerlyCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(30);
        }
    }

    public void BuyKibbutz()
    {
        char compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.kibbutzCost);
        if ((compare == '>') || (compare == '='))
        {
            GlobalShekels.ShekelCount.minus(GlobalUpgrades.kibbutzCost);
            GlobalUpgrades.kibbutzCost.multiplySmall(2);
            kibbutz.transform.Find("Cost").GetComponent<Text>().text = "" + (GlobalUpgrades.kibbutzCost.showAsLetter());
            Autoclicker.moneyPerSec.plusSmall(50);
        }
    }

    IEnumerator ShopCooldown()
    {
        yield return new WaitForSeconds(1);
    }
}
