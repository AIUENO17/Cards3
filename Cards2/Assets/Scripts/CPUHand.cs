using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CPUHand : MonoBehaviour
{
    [SerializeField] private CardDealer m_cardDlealer = null;
    [SerializeField] private List<RectTransform> m_cpuCards = new List<RectTransform>();
    private List<Card> m_cpuHand = new List<Card>();

    private void Start()
    {
        m_cardDlealer.CardDeal(m_cpuHand);
        CardUpDate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    private void CardUpDate()
    {
        for (int i = 0; i < m_cpuHand.Count; i++)
        {
            var card = m_cpuHand[i];
            m_cpuCards[i].GetComponentInChildren<TextMeshProUGUI>().text = $"{card.CardSuit}:{card.Number}";
        }
    }
}