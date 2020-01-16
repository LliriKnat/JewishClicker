using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoShekel : MonoBehaviour
{
    public GameObject MessagePrefab;
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

    void Start()
    {
        if (PlayerPrefs.GetString("Money") != "")
            GlobalShekels.ShekelCount.setFromString(PlayerPrefs.GetString("Money"));
        if (PlayerPrefs.GetString("Revenue") != "")
            Autoclicker.moneyPerSec.setFromString(PlayerPrefs.GetString("Revenue"));
        if (PlayerPrefs.GetString("GoyCost") != "")
            GlobalUpgrades.goyCost.setFromString(PlayerPrefs.GetString("GoyCost"));
        if (PlayerPrefs.GetString("MoneylanderCost") != "")
            GlobalUpgrades.moneylanderCost.setFromString(PlayerPrefs.GetString("MoneylanderCost"));
        if (PlayerPrefs.GetString("RabbiCost") != "")
            GlobalUpgrades.rabbiCost.setFromString(PlayerPrefs.GetString("RabbiCost"));
        if (PlayerPrefs.GetString("SynagogueCost") != "")
            GlobalUpgrades.synagogueCost.setFromString(PlayerPrefs.GetString("SynagogueCost"));
        if (PlayerPrefs.GetString("JewerlyCost") != "")
            GlobalUpgrades.jewerlyCost.setFromString(PlayerPrefs.GetString("JewerlyCost"));
        if (PlayerPrefs.GetString("KibbutzCost") != "")
            GlobalUpgrades.kibbutzCost.setFromString(PlayerPrefs.GetString("KibbutzCost"));
        if (PlayerPrefs.GetString("Clicks") != "")
            MainShekelClick.clickCount.setFromString(PlayerPrefs.GetString("Clicks"));

        if (PlayerPrefs.GetString("LastEntry") != "")
        {
            //время последнего входа
            System.DateTime lastEntryTime = new System.DateTime();
            lastEntryTime = System.DateTime.Parse(PlayerPrefs.GetString("LastEntry"), System.Globalization.CultureInfo.InvariantCulture);
            //сколько накопилось за время отсутствия
            BigInt gatheredMoney = new BigInt();
            BigInt income = new BigInt();
            income.setFromString(PlayerPrefs.GetString("Revenue"));


            if (System.DateTime.Now > lastEntryTime)
            {

                // подсчет дохода за секунды
                BigInt secMoney = new BigInt(income);
                secMoney.multiply(Mathf.Abs(System.DateTime.Now.Second - lastEntryTime.Second));
                bool minusSecFlag;
                if (System.DateTime.Now.Second - lastEntryTime.Second >= 0)
                    minusSecFlag = false;
                else
                    minusSecFlag = true;


                // подсчет дохода за минуты
                income.multiply(60);
                BigInt minMoney = new BigInt(income);
                minMoney.multiply(Mathf.Abs(System.DateTime.Now.Minute - lastEntryTime.Minute));
                bool minusMinFlag;
                if (System.DateTime.Now.Minute - lastEntryTime.Minute >= 0)
                    minusMinFlag = false;
                else
                    minusMinFlag = true;

                // подсчет дохода за часы
                income.multiply(60);
                BigInt hourMoney = new BigInt(income);
                hourMoney.multiply(Mathf.Abs(System.DateTime.Now.Hour - lastEntryTime.Hour));
                bool minusHourFlag;
                if (System.DateTime.Now.Hour - lastEntryTime.Hour >= 0)
                    minusHourFlag = false;
                else
                    minusHourFlag = true;


                // подсчет дохода за дни
                income.multiply(24);
                BigInt dayMoney = new BigInt(income);
                dayMoney.multiply(Mathf.Abs(System.DateTime.Now.Day - lastEntryTime.Day));
                bool minusDayFlag;
                if (System.DateTime.Now.Day - lastEntryTime.Day >= 0)
                    minusDayFlag = false;
                else
                    minusDayFlag = true;

                // подсчет дохода за месяцы
                income.multiply(32);
                BigInt monthMoney = new BigInt(income);
                monthMoney.multiply(Mathf.Abs(System.DateTime.Now.Month - lastEntryTime.Month));
                bool minusMonthFlag;
                if (System.DateTime.Now.Month - lastEntryTime.Month >= 0)
                    minusMonthFlag = false;
                else
                    minusMonthFlag = true;

                // подсчет дохода за года
                income.multiply(500);
                BigInt yearMoney = new BigInt(income);
                yearMoney.multiply(Mathf.Abs(System.DateTime.Now.Year - lastEntryTime.Year));

                // суммарный доход

                gatheredMoney.plus(yearMoney);

                if (!minusMonthFlag)
                    gatheredMoney.plus(monthMoney);
                else
                    gatheredMoney.minus(monthMoney);

                if (!minusDayFlag)
                    gatheredMoney.plus(dayMoney);
                else
                    gatheredMoney.minus(dayMoney);

                if (!minusHourFlag)
                    gatheredMoney.plus(hourMoney);
                else
                    gatheredMoney.minus(hourMoney);

                if (!minusMinFlag)
                    gatheredMoney.plus(minMoney);
                else
                    gatheredMoney.minus(minMoney);

                if (!minusSecFlag)
                    gatheredMoney.plus(secMoney);
                else
                    gatheredMoney.minus(secMoney);

                Debug.Log(GlobalShekels.ShekelCount.show());

                GlobalShekels.ShekelCount.plus(gatheredMoney);
            }
            else if (System.DateTime.Now < lastEntryTime)
            {
            }

            if (MessagePrefab && (gatheredMoney.compare(0) == '>') )
            {
                var text = Instantiate(MessagePrefab, new Vector3(0, -3, 0), Quaternion.identity, transform);
                text.transform.Find("Text").GetComponent<TMPro.TextMeshProUGUI>().text = "You've earned " + gatheredMoney.show() + " shekels!";
            }
        }
    }

    void Update()
    {
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.goyCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.goyCost.compare(25) == '>'))
        {
            goyFlag = true;
        }
        else
            goyFlag = false;
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.moneylanderCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.moneylanderCost.compare(100) == '>'))
        {
            moneylanderFlag = true;
        }
        else
            moneylanderFlag = false;
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.rabbiCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.rabbiCost.compare(500) == '>'))
        {
            rabbiFlag = true;
        }
        else
            rabbiFlag = false;
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.synagogueCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.synagogueCost.compare(1250) == '>'))
        {
            synagogueFlag = true;
        }
        else
            synagogueFlag = false;
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.jewerlyCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.jewerlyCost.compare(2000) == '>'))
        {
            jewerlyFlag = true;
        }
        else
            jewerlyFlag = false;
        //
        compare = GlobalShekels.ShekelCount.compare(GlobalUpgrades.kibbutzCost);
        if ((compare == '>') || (compare == '=') || (GlobalUpgrades.kibbutzCost.compare(5000) == '>'))
        {
            kibbutzFlag = true;
        }
        else
            kibbutzFlag = false;
        //

        ShekelIncrease = Autoclicker.moneyPerSec;
        InternalIncrease = ShekelIncrease;
        if (CreatingShekel == false)
        {
            CreatingShekel = true;
            StartCoroutine(CreateTheShekel());
        }

        //Saving the data
        PlayerPrefs.SetString("Money", GlobalShekels.ShekelCount.show());
        PlayerPrefs.SetString("Revenue", Autoclicker.moneyPerSec.show());
        PlayerPrefs.SetString("GoyCost", GlobalUpgrades.goyCost.show());
        PlayerPrefs.SetString("MoneylanderCost", GlobalUpgrades.moneylanderCost.show());
        PlayerPrefs.SetString("RabbiCost", GlobalUpgrades.rabbiCost.show());
        PlayerPrefs.SetString("SynagogueCost", GlobalUpgrades.synagogueCost.show());
        PlayerPrefs.SetString("JewerlyCost", GlobalUpgrades.jewerlyCost.show());
        PlayerPrefs.SetString("KibbutzCost", GlobalUpgrades.kibbutzCost.show());
        PlayerPrefs.SetString("Clicks", MainShekelClick.clickCount.show());
        PlayerPrefs.SetString("LastEntry", System.DateTime.Now.ToString(System.Globalization.CultureInfo.InvariantCulture));
    }

    IEnumerator CreateTheShekel()
    {
        GlobalShekels.ShekelCount.plus(InternalIncrease);
        yield return new WaitForSeconds(1);
        CreatingShekel = false; 
    }
}
