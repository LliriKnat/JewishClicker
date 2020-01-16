using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainShekelClick : MonoBehaviour
{
    public static BigInt clickCount = new BigInt();

    public void ClickTheShekel()
    {
        GlobalShekels.ShekelCount.plusSmall(1);
        clickCount.plusSmall(1);
    }

}
