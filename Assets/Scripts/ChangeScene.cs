using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject statusBox;
    public void ChangeToMain()
    {
        SceneManager.LoadScene(1);
        statusBox.GetComponent<Text>().text = "Moving to the main screen...";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }

    public void ChangeToShop()
    {
        SceneManager.LoadScene(2);
        statusBox.GetComponent<Text>().text = "Moving to the shop screen...";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }

    public void ChangeToOldMain()
    {
        SceneManager.LoadScene(0);
        statusBox.GetComponent<Text>().text = "YAY! OLD VERSION!!!";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }
}
