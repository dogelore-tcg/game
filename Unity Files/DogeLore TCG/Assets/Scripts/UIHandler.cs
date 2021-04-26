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
    //note - images are not sprites, this may be intentional by Ty, but I don't know, please get back to me when you see this Ty.
    //TODO - remove this comment after Ty responds.
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
        
        //when the attack button is pressed, deal damage to enemy card based on player card attack.
        enemyCard.health -= playersCard.attack;
        Debug.Log("Player's card attacks enemy card for "+playersCard.attack+" damage.");

        //also subtract health from player's card based on enemy card defence
        playersCard.health -= enemyCard.defence;
        Debug.Log("Enemy card's defense deals "+enemyCard.defence+" damage back.");

        //after an attack, check if cards still have health. If not, set them to dead status.
        if (playersCard.health<=0)
        {
            playersCard.alive = false;
            Debug.Log("Player's card dies");
        }
        if (enemyCard.health <= 0)
        {
            enemyCard.alive = false;
            Debug.Log("Enemy's card dies");
        }
        Debug.Log("\nPlayer's card current health:"+playersCard.health+"\nEnemy's card current health:"+enemyCard.health);
    }
}
