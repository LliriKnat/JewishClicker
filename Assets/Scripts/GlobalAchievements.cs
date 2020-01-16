using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //General Variables
    public AudioSource achSound;
    public static int achCount;
    private char compare;

    //Achievement 1 specific
    public static int ach01Trigger = 100;
    public static bool ach01Active = false;

    //Achievement 2 specific
    public static int ach02Trigger = 1;
    public static bool ach02Active = false;

    //Achievement 3 specific
    public static int ach03Trigger = 50;
    public static bool ach03Active = false;

    //Achievement 4 specific
    public static int ach04Trigger = 228;
    public static bool ach04Active = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        compare = MainShekelClick.clickCount.compare(ach01Trigger);
        if (((compare == '=') || (compare == '>')) && !ach01Active)
        {
            achCount += 1;
            ach01Active = true;
            achSound.Play();
        }

        compare = Autoclicker.moneyPerSec.compare(ach02Trigger);
        if (((compare == '=') || (compare == '>')) && !ach02Active)
        {
            achCount += 1;
            ach02Active = true;
            achSound.Play();
        }

        compare = Autoclicker.moneyPerSec.compare(ach03Trigger);
        if (((compare == '=') || (compare == '>')) && !ach03Active)
        {
            achCount += 1;
            ach03Active = true;
            achSound.Play();
        }

        compare = MainShekelClick.clickCount.compare(ach04Trigger);
        if (((compare == '=') || (compare == '>')) && !ach04Active)
        {
            achCount += 1;
            ach04Active = true;
            achSound.Play();
        }
    }
}
