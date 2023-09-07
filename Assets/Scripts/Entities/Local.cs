using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Local : MonoBehaviour
{
    public GameObject LocalUI;

    public void OnClick()
    {
        UIController.U.IsLocalActive = !UIController.U.IsLocalActive;
        LocalUI.SetActive(UIController.U.IsLocalActive);

        UIController.U.SearchName();
    }
}
