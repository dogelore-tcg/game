using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // other references
    public UIHandler uih;

    // this is every card that exists
    public Card[] cards;
    // -----------------------------
    public int maxCardsInHand = 5;
    public int maxCardsInPlay = 3;

    public Card[] playersCardsInPlay;
    public Card[] playersCards;

    public Card[] enemiesCardsInPlay;
    public Card[] enemiesCards;

    // Start is called before the first frame update
    void Start()
    {
        uih = FindObjectOfType<UIHandler>();

        // set up card group sizes
        playersCards = new Card[maxCardsInHand];
        playersCardsInPlay = new Card[maxCardsInPlay];

        enemiesCards = new Card[maxCardsInHand];
        enemiesCardsInPlay = new Card[maxCardsInPlay];


        for (int i = 0; i < maxCardsInHand; i++)
        {
            Card _cardReference = cards[Random.Range(0, cards.Length)];
            playersCards[i] = new Card(_cardImage: _cardReference.cardImage, _cardName: _cardReference.cardName, _health: _cardReference.health, _attack: _cardReference.attack, _defence: _cardReference.defence, _team: 0, _place: 0);

            _cardReference = cards[Random.Range(0, cards.Length)];
            enemiesCards[i] = new Card(_cardImage: _cardReference.cardImage, _cardName: _cardReference.cardName, _health: _cardReference.health, _attack: _cardReference.attack, _defence: _cardReference.defence, _team: 0, _place: 0);
        }

        enemiesCardsInPlay[0] = enemiesCards[Random.Range(0, enemiesCards.Length)];
        playersCardsInPlay[0] = playersCards[Random.Range(0, playersCards.Length)];




        uih.playersCard = playersCardsInPlay[0];
        uih.enemyCard = enemiesCardsInPlay[0];

    }

    private void Update()
    {
        uih.SetUI();
    }
}
