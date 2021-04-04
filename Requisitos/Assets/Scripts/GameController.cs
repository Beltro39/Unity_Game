using UnityEngine;
using Photon.Pun;

public class GameController : MonoBehaviourPun
{
    [SerializeField]
    

    // Start is called before the first frame update
    private void Awake(){
        int i= PhotonNetwork.CurrentRoom.PlayerCount-1;
        if(i==0){
           PhotonNetwork.Instantiate("Player", new Vector3(0, -550, 0), Quaternion.identity, 0);
    }
       if(i==1){
           PhotonNetwork.Instantiate("Player", new Vector3(910, 0, 0), Quaternion.Euler(0,0,90), 0);
    }
    if(i==2){
           PhotonNetwork.Instantiate("Player", new Vector3(0, 550, 0), Quaternion.Euler(0,0,180), 0);
    }
    if(i==3){
           PhotonNetwork.Instantiate("Player", new Vector3(-910, 0, 0), Quaternion.Euler(0,0,270), 0);
    }

        }
        
        //
}
