using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLoadAchievements : MonoBehaviour
{
    public GameObject count;
    public GameObject ach01;
    public GameObject ach02;
    public GameObject ach03;
    public GameObject ach04;
    private char compare;
    void Start()
    {
        compare = MainShekelClick.clickCount.compare(GlobalAchievements.ach01Trigger);
        if ((compare == '=') || (compare == '>'))
            ach01.transform.Find("Progress").GetComponent<Text>().text = "100/100";
        else
            ach01.transform.Find("Progress").GetComponent<Text>().text = MainShekelClick.clickCount.show() + "/100";

        compare = Autoclicker.moneyPerSec.compare(GlobalAchievements.ach02Trigger);
        if ((compare == '=') || (compare == '>'))
            ach02.transform.Find("Progress").GetComponent<Text>().text = "1/1";
        else
            ach02.transform.Find("Progress").GetComponent<Text>().text = Autoclicker.moneyPerSec.show() + "/1";

        compare = Autoclicker.moneyPerSec.compare(GlobalAchievements.ach03Trigger);
        if ((compare == '=') || (compare == '>'))
            ach03.transform.Find("Progress").GetComponent<Text>().text = "50/50";
        else
            ach03.transform.Find("Progress").GetComponent<Text>().text = Autoclicker.moneyPerSec.show() + "/50";

        compare = MainShekelClick.clickCount.compare(GlobalAchievements.ach04Trigger);
        if ((compare == '=') || (compare == '>'))
            ach04.transform.Find("Progress").GetComponent<Text>().text = "228/228";
        else
            ach04.transform.Find("Progress").GetComponent<Text>().text = MainShekelClick.clickCount.show() + "/228";

        count.GetComponent<Text>().text = "Total achievements: " + GlobalAchievements.achCount;
        if (GlobalAchievements.ach01Active)
            ach01.SetActive(true);
        if (GlobalAchievements.ach02Active)
            ach02.SetActive(true);
        if (GlobalAchievements.ach03Active)
            ach03.SetActive(true);
        if (GlobalAchievements.ach04Active)
            ach04.SetActive(true);
    }
}
