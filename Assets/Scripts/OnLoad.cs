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
    void Start()
    {
        goy.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.goyCost;
        moneylander.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.moneylanderCost;
        rabbi.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.rabbiCost;
        synagogue.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.synagogueCost;
        jewerly.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.jewerlyCost;
        kibbutz.transform.Find("Cost").GetComponent<Text>().text = "" + GlobalUpgrades.kibbutzCost;
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
}
