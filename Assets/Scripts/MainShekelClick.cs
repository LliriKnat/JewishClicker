using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainShekelClick : MonoBehaviour
{
    public GameObject statusBox;
    public void ClickTheShekel()
    {
        GlobalShekels.ShekelCount += 1;
        statusBox.GetComponent<Animation>().Stop("StatusAnimation");
        statusBox.GetComponent<Text>().text = "Oy vey! We need more shekels!";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }

}
