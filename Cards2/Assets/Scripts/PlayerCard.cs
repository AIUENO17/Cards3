using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public CardDealer CardDealer;

    private List<Card> playerDeck = new List<Card>();

    public Card playerCard;

    public Image PlayerCardImage;

    public CardImageHelper cardImageHelper;

    public void SetPlayerDeck()
    {
        playerDeck = CardDealer.GetPlayerDeck();
    }

    public void SetPlayerCard()
    {
        playerCard = Deck.GetCard(playerDeck);
        PlayerCardImage.sprite = cardImageHelper.GetCardSprite(playerCard);
    }
}
