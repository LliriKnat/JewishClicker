using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShekel : MonoBehaviour
{

    public bool CreatingShekel = false;
    public static int ShekelIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        ShekelIncrease = GlobalJewerlyJew.jewerlyPerSec;
        InternalIncrease = ShekelIncrease;
        if (CreatingShekel == false)
        {
            CreatingShekel = true;
            StartCoroutine(CreateTheShekel());
        }
    }

    IEnumerator CreateTheShekel()
    {
        GlobalShekels.ShekelCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingShekel = false; 
    }
}
