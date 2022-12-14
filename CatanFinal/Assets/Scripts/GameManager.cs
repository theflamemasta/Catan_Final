using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> brickDeck = new List<Card>();
    public List<Card> sheepDeck = new List<Card>();
    public List<Card> woodDeck = new List<Card>();
    public List<Card> wheatDeck = new List<Card>();
    public List<Card> oreDeck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;
    public Text deckSizeText;

    public void DrawCard()
    {
        if(deck.Count >= 1)
        {
            Card randCard = deck[Random.Range(0, deck.Count)];

            for (int i =0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }
    public void BrickDrawCard()
    {
        if (brickDeck.Count >= 1)
        {
            Card randCard = brickDeck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    brickDeck.Remove(randCard);
                    return;
                }
            }
        }
    }
    public void SheepDrawCard()
    {
        if (sheepDeck.Count >= 1)
        {
            Card randCard = sheepDeck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    sheepDeck.Remove(randCard);
                    return;
                }
            }
        }
    }
    public void WoodDrawCard()
    {
        if (woodDeck.Count >= 1)
        {
            Card randCard = woodDeck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    woodDeck.Remove(randCard);
                    return;
                }
            }
        }
    }
    public void WheatDrawCard()
    {
        if (wheatDeck.Count >= 1)
        {
            Card randCard = wheatDeck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    wheatDeck.Remove(randCard);
                    return;
                }
            }
        }
    }
    public void OreDrawCard()
    {
        if (oreDeck.Count >= 1)
        {
            Card randCard = oreDeck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    oreDeck.Remove(randCard);
                    return;
                }
            }
        }
    }

    private void Update()
    {
        deckSizeText.text = deck.Count.ToString();
    }
}
