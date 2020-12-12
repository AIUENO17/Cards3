using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAndLowSequence : MonoBehaviour
{

    private enum GameSequence
    {
        Invalide,
        Init,
        Start,
        Deal,
        PlayerJudge,
        Show
    }

    private GameSequence gameSequence = GameSequence.Invalide;

    public CardDealer CardDealer;

    public PlayerCard playerCard;
    public CPUCard cpuCard;

    public PlayerJudge playerJudge;

    void Update()
    {
        switch (gameSequence)
        {
            case GameSequence.Invalide:

                gameSequence = GameSequence.Init;
                break;

            case GameSequence.Init:

                playerCard.SetPlayerDeck();
                cpuCard.SetCPUdeck();
                gameSequence = GameSequence.Deal;
                break;

            case GameSequence.Start:

                gameSequence = GameSequence.Deal;
                break;

            case GameSequence.Deal:
                playerCard.SetPlayerCard();
                cpuCard.SetCPUCard();
                Debug.Log(playerCard.playerCard.Number);
                Debug.Log(cpuCard.cpuCard.Number);
                gameSequence = GameSequence.PlayerJudge;

                if (playerJudge.Judge)
                {
                    gameSequence = GameSequence.Show;
                        
                }
                break;

            case GameSequence.Show:

                cpuCard.ShowCPUCard();

                if (playerJudge.High)
                {
                    if (playerCard.playerCard.Number > cpuCard.cpuCard.Number)
                    {
                        Debug.Log("勝ち");
                    }
                    else
                    {
                        Debug.Log("負け");
                    }
                }
                playerJudge.Judge = false;
                gameSequence = GameSequence.Start;
                break;




        }
    }
}
