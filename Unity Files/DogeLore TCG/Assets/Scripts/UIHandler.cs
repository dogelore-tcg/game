using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{

    private GameManager gm;

    public Card playersCard;
    public Card enemyCard;

    [Header("Player card")]
    public Image playerCardImage;
    public TextMeshProUGUI playerCardName;
    public TextMeshProUGUI playerCardHealth;
    public TextMeshProUGUI playerCardAttack;
    public TextMeshProUGUI playerCardDefence;

    [Header("Enemy card")]
    public Image enemyCardImage;
    public TextMeshProUGUI enemyCardName;
    public TextMeshProUGUI enemyCardHealth;
    public TextMeshProUGUI enemyCardAttack;
    public TextMeshProUGUI enemyCardDefence;


    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public void SetUI()
    {
        playerCardName.text = playersCard.cardName;
        enemyCardName.text = enemyCard.cardName;

        playerCardHealth.text = "Health: " + playersCard.health;
        enemyCardHealth.text = "Health: " + enemyCard.health;

        playerCardAttack.text = "Attack: " + playersCard.attack;
        enemyCardAttack.text = "Attack: " + enemyCard.attack;

        playerCardDefence.text = "Defence: " + playersCard.defence;
        enemyCardDefence.text = "Defence: " + enemyCard.defence;
    }

    public void Attack()
    {
        enemyCard.health -= playersCard.attack;
    }
}
