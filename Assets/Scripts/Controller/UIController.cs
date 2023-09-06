using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public event Action OnSelectCharacterEvent;
    public event Action<string> OnPrintMessage;

    public void CallSelectCharacterEvent()
    {
        OnSelectCharacterEvent?.Invoke();
    }

    public void CallPrintMessage(string msg)
    {
        OnPrintMessage?.Invoke(msg);
    }
}
