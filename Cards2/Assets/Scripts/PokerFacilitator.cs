using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerFacilitator : MonoBehaviour
{
    [SerializeField] private PlayerHand m_playerHand;
    [SerializeField] private CPUHand m_cpuHand;

    public static int ChangeCount = 1;

    private enum GameState
    {
        Invalid = -1,
        Init,
        Deal,
        Change,
        Judge,
        Result
    }

    private GameState m_gameState = GameState.Invalid;
    

    
    void Update()
    {
        switch (m_gameState)
        {
            case GameState.Invalid:
                m_gameState = GameState.Init;
                    break;
            case GameState.Init:
                m_gameState = GameState.Deal;
                break;
            

                
                
            case GameState.Change:
                if (ChangeCount < 1)
                {
                    m_gameState = GameState.Judge;
                }
                break;
         
                

            case GameState.Result:
                break;
   
        }
    }
}
