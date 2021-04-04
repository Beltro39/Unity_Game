using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour

{
   public Image image;
   public Card c;
   public GameObject Hand;
   public GameObject Deck;
   public int NextCard;

   void Start(){
      
   }

   public void Update(){
     /*
       if(this.tag=="InHand1"){
         Hand= GameObject.Find("Hand");
         tag= "InHand2";
       }
       if(this.tag=="InHand2"){
         Hand= GameObject.Find("Hand2");
         tag= "InHand3";
       }
       if(this.tag=="InHand3"){
         Hand= GameObject.Find("Hand3");
         tag= "InHand4";
       }
       if(this.tag=="InHand4"){
         Hand= GameObject.Find("Hand4");
         tag= "Static";
       }
       */
       if(this.tag== "FromDeck"){
           Deck= GameObject.Find("Deck");
           NextCard=Deck.GetComponent<PlayerDeck>().deckSize -1;
           c= Deck.GetComponent<PlayerDeck>().deck[NextCard];
           Deck.GetComponent<PlayerDeck>().deckSize-= 1;

           if(Deck.tag=="InHand4"){
             Hand= GameObject.Find("Hand4");
             transform.eulerAngles= new Vector3(0,0,270);
           }
           if(Deck.tag=="InHand3"){
             Hand= GameObject.Find("Hand3");
             Deck.tag="InHand4";
             transform.eulerAngles= new Vector3(0,0,180);
           }
           if(Deck.tag=="InHand2"){
             Hand= GameObject.Find("Hand2");
             Deck.tag="InHand3";
             transform.eulerAngles= new Vector3(0,0,90);
           }

           if(Deck.tag=="InHand1"){
             Hand= GameObject.Find("Hand");
             Deck.tag= "InHand2";
           }
           
           
           

           
           
           transform.SetParent(Hand.transform);
           transform.localScale= Vector3.one;
           transform.localPosition= new Vector3(0,0,0);
           

           LoadCard();
           tag= "InHand";

            
         

       }

     
   }

   public void LoadCard(){
       image.sprite= c.image;
   }
}
