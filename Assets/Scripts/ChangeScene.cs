using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeToMain()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToShop()
    {
        SceneManager.LoadScene(2);
    }

    public void ChangeToAchievements()
    {
        SceneManager.LoadScene(3);
    }

    public void ChangeToSettings()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void ClearProgress()
    {
        PlayerPrefs.DeleteAll();
        GlobalShekels.ShekelCount.setFromString("0");
        Autoclicker.moneyPerSec.setFromString("0");
        GlobalUpgrades.goyCost.setFromString("25");
        GlobalUpgrades.moneylanderCost.setFromString("100");
        GlobalUpgrades.rabbiCost.setFromString("500");
        GlobalUpgrades.synagogueCost.setFromString("1250");
        GlobalUpgrades.jewerlyCost.setFromString("2000");
        GlobalUpgrades.kibbutzCost.setFromString("5000");
        MainShekelClick.clickCount.setFromString("0");
        GlobalAchievements.achCount = 0;
        GlobalAchievements.ach01Active = false;
        GlobalAchievements.ach02Active = false;
        GlobalAchievements.ach03Active = false;
        GlobalAchievements.ach04Active = false;
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
