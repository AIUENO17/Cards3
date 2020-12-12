using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Deck 
{
    //昇順のDeckをゲットする

    public static List<Card> GetDeck()
    {
        var deck = new List<Card>();

        for (int i = 0; i < Card.CardMax; i++)
        {
            deck.Add(new Card(Card.CardSuitJudge(i),Card.CardNumJudge(i)));
        }
        return deck;
    }
    //シャッフルしたDeckをゲットする
    //OrderByで昇順にソート
    //guidこれを利用して52回、数値の番地を決める
    public static List<Card> ShuffleDeck(List<Card> deck)
    {
        var shuffleDeck = deck.OrderBy(card => Guid.NewGuid()).ToList();
        return shuffleDeck;

    }

    //カードをDeckの中から取得する
        public static Card GetCard(List<Card> deck)
        {
            var card = deck.First();
            deck.RemoveAt(0);
            return card;
        }
    }
   
