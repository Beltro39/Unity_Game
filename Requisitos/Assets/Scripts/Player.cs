using System.Collections;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Player : MonoBehaviourPun
{
    private Text caption= null;
    // Start is called before the first frame update
    private void Start()
    {
        //for(int i= 0; i< this.transform.childCount; i++){
        //    if(this.transform.GetChild(i).name== "Caption_Text"){
          //      caption= this.transform.GetChild(i).gameObject.GetComponent<Text>();
          //      caption.text= string.Format("Jugador{0}", photonView.ViewID);
          //  }
       // }
       caption= this.gameObject.GetComponent<Text>();
       caption.text= string.Format("Jugador{0}", photonView.ViewID);
    }

    // Update is called once per frame
   void Awake()
{
    this.transform.SetParent(GameObject.Find("Canvas").GetComponent<Transform>(), false);
}
}
