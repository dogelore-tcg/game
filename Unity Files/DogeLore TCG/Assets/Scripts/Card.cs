using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// written by Ty 2021

[CreateAssetMenu(fileName = "New Card", menuName = "Card")] // dont touch this line
public class Card : ScriptableObject
{
    public string cardName;
    public Sprite cardImage;
    public int health;
    public int attack;
    public int defence;
    public int team;
    public int place;

    public Card(string _cardName, Sprite _cardImage, int _health, int _attack, int _defence, int _team, int _place)
    {
        cardName = _cardName;
        cardImage = _cardImage;
        health = _health;
        attack = _attack;
        defence = _defence;
        team = _team;
        place = _place;
    }
}
