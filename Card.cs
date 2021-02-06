using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public Sprite cardImage;
    public string cardName;
    public int attack;
    public int defence;
    public int team;
    public int place;
}
