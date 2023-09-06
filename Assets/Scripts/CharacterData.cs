using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Object/CharacterData")]
public class CharacterData : ScriptableObject
{
    public enum CharacterType { Knight, Merchant, Peasant, Priest }
    public CharacterType characterType;
    public GameObject Character;
    public Sprite Image;
}
