using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyInfo : MonoBehaviour
{
    public GameObject StartUI;

    public GameObject printMessage;
    public InputField inputField;
    public Text playerName;

    public void OnClickSaveName()
    {
        if (inputField.text.Length >= 2 && inputField.text.Length <= 6)
        {
            playerName.text = inputField.text;
            StartUI.SetActive(false);
        }
        else
        {
            PrintMessage("이름은 최소 2글자 최대 6글자까지 입력 가능합니다.");
        }
    }

    private void PrintMessage(string msg)
    {
        GameObject g = Instantiate(printMessage);
        g.transform.parent = GameObject.Find("PrintMessage").transform;
        g.GetComponent<PrintMessage>().MsgSet(msg);
        g.transform.position = new Vector3(0, 0, 0);
    }

    public void OnClickMyInfo()
    {
        StartUI.SetActive(true);
    }

}
