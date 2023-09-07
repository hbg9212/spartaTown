using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static UIController U;

    private void Awake()
    {
        U = this;
    }

    public GameObject CharacterBtn;
    public GameObject SelectCharacter;
    public GameObject Player;
    public Text LocalText;

    public event Action OnSelectCharacterEvent;
    public event Action<string> OnPrintMessage;

    public bool IsLocalActive = false;

    public void CallSelectCharacterEvent()
    {
        OnSelectCharacterEvent?.Invoke();
    }

    public void CallPrintMessage(string msg)
    {
        OnPrintMessage?.Invoke(msg);
    }

    public void SearchName()
    {
        if(IsLocalActive)
        {
            string names = "";
            Text[] name = Player.GetComponentsInChildren<Text>();
            foreach (Text t in name)
            {
                names = names + t.text + "\n";
            }

            LocalText.text = names;
        }
    }
}
