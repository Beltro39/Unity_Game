using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Card> deck;
    public CardDataBase personalityCards;
    public int deckSize;
    public int x;
    void Start()
    {
        for(int i=0;i<deckSize; i++){
         x= i;
         deck[i]= personalityCards.collection[x];

        }
        
        
    }

    // Update is called once per frame
    
}
