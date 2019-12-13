using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoclicker : MonoBehaviour
{
    public static int moneyPerSec = 0;
    public GameObject upgrade;
    public GameObject AutoShekel;

    public void BuyUpgrade()
    {
        AutoShekel.SetActive(true);
        GlobalShekels.ShekelCount -= int.Parse(upgrade.transform.Find("Cost").GetComponent<Text>().text);
        upgrade.transform.Find("Cost").GetComponent<Text>().text = "" + (int.Parse(upgrade.transform.Find("Cost").GetComponent<Text>().text) * 2);
        //GlobalJewerlyJew.turnOffJewerly = true;
        moneyPerSec += int.Parse(upgrade.transform.Find("Description").GetComponent<Text>().text);
        Debug.Log(int.Parse(upgrade.transform.Find("Description").GetComponent<Text>().text));
        //GlobalJewerlyJew.numberOfJewerlyJews += 1;
    }

    void Update()
    {
        
    }
}
