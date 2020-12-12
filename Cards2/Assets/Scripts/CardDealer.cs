using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
    //List<型名> 変数名　= new List<型名>();
    private List<Card> deck = new List<Card>();
    //List
    private List<Card> playerHand = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {

        deck = Deck.ShuffleDeck(Deck.GetDeck());

    }
    private void Awake()
    {
        GameStart();
    }

    public List<Card> GetPlayerDeck()
    {
        var playerDeck = deck.Where((c, i) => i % 2 != 0).ToList();
        return playerDeck;
    }

    public List<Card> GetCPUDeck()
    {
        var cpuDeck = deck.Where((c, i) => i % 2 == 0).ToList();
        return cpuDeck;
    }

    public void GameStart()
    {
        deck = Deck.GetDeck();
        deck = Deck.ShuffleDeck(deck);
    }
    public void CardDeal(List<Card> playerHand)
    {
        playerHand.Clear();

        if (deck.Count < 1)
        {
            deck.Clear();
            deck = Deck.ShuffleDeck(Deck.GetDeck());
        }

        for (int i = 0; i < 1; i++)
        {
            playerHand.Add(Deck.GetCard(deck));
        }
        foreach (var card in playerHand)
        {
            Debug.Log($"{card.CardSuit}:{card.Number}");
        }

        
    }
}