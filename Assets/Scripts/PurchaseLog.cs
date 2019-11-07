using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoShekel;
    public AudioSource playSound;

    public void StartAutoShekel()
    {
        playSound.Play();
        AutoShekel.SetActive(true);
        GlobalShekels.ShekelCount -= GlobalJewerlyJew.jewerlyJewValue;
        GlobalJewerlyJew.jewerlyJewValue *= 2;
        GlobalJewerlyJew.turnOffJewerly = true;
        GlobalJewerlyJew.jewerlyPerSec += 1;
        GlobalJewerlyJew.numberOfJewerlyJews += 1;
    }
}
