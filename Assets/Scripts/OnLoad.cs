using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLoad : MonoBehaviour
{
    public GameObject goy;
    public GameObject moneylander;
    public GameObject rabbi;
    public GameObject synagogue;
    public GameObject jewerly;
    public GameObject kibbutz;
    public GameObject status;
    void Start()
    {
        goy.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.goyCost.showAsLetter();
        moneylander.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.moneylanderCost.showAsLetter();
        rabbi.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.rabbiCost.showAsLetter();
        synagogue.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.synagogueCost.showAsLetter();
        jewerly.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.jewerlyCost.showAsLetter();
        kibbutz.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.kibbutzCost.showAsLetter();
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
    }

    void Update()
    {
        status.transform.Find("CurrentMoney").GetComponent<Text>().text = "Current Money: " + GlobalShekels.ShekelCount.showAsLetter();
        status.transform.Find("MoneyPerSecond").GetComponent<Text>().text = "Generating " + Autoclicker.moneyPerSec.showAsLetter() + " per second";
    }
}