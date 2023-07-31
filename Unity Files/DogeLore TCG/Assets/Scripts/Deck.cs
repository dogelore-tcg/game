using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    //Deck will be used to shuffle card decks as well as draw and keeps track of all abilities.

    //Number of abilities currently in game. Update whenever a new ability is added or removed.
    private int numOfAbilities = 2;
    public string[] ability;


    //Player's deck
    public List<Card> playerDeck;
    //Enemy's deck
    public List<Card> enemyDeck;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Deck system in use.");
        //initates abilities string with a length equal to the number of abilities.
        ability = new string[numOfAbilities];
        ability[0] = "Stun";
        ability[1] = "Shuffle";
    }


    //Stun ability, ID 0, Applies stunturns turns of stun to stunnedCard
    public void stun(int stunturns,Card stunnedCard)
    {
        stunnedCard.stunned = true;
        stunnedCard.stunnedTurns += stunturns;
    }

    //Shuffle ability, ID 1, Shuffles cardAdded into a player's deck (deckAddedTo).
    public void shuffle(Card cardAdded, List<Card> deckAddedTo)
    {
        //TODO - finish this ability
        //this adds the card to the list at the end, we might want to randomize the items location in the list, but for now this is what I'm going with.
        deckAddedTo.Add(cardAdded);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
