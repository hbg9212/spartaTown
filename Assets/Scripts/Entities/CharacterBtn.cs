using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour
{
    public CharacterData data;
    public string character;

    public void OnClick()
    {
        if(character == "select")
        {
            Player.P.GetComponent<PlayerInputController>().enabled = false;
            Player.P.GetComponent<Shooting>().enabled = false;
            Transform playerParent = GameObject.Find("Player/Character").transform;
            foreach (Transform child in playerParent)
            {
                Destroy(child.gameObject);
            }

            UIController.U.CharacterBtn.SetActive(false);
            UIController.U.SelectCharacter.SetActive(true);
        }
        else
        {
            UIController.U.CharacterBtn.SetActive(true);
            Transform playerParent = GameObject.Find("Player/Character").transform;
            Instantiate(data.Character, playerParent);

            GameObject.Find("StartUI/CharacterBtn/Btn/Image").GetComponent<Image>().sprite = data.Image;

            UIController.U.SelectCharacter.SetActive(false);
            Player.P.GetComponent<PlayerInputController>().enabled = true;
            Player.P.GetComponent<Shooting>().enabled = true;
        }
    }
}
