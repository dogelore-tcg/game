using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// written by Ty 2021

[CreateAssetMenu(fileName = "New Card", menuName = "Card")] // dont touch this line
public class Card : ScriptableObject
{
    public Sprite cardImage;
    public string cardName;
    public int attack;
    public int defence;
    public int team;
    public int place;
}
