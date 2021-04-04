using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject start_Button;
    [SerializeField] private Text status_Text = null;

    private byte maximum_Players = 4;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        start_Button.SetActive(false);
        Status("Connecting to server");
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        PhotonNetwork.AutomaticallySyncScene = true;  ///Todos los jugadores se ven en la misma escena
        start_Button.SetActive(true);
        Status("Connected to " + PhotonNetwork.ServerAddress);
    }

    public void OnButtonStart()
    {
        string roomName = "Room1";
        Photon.Realtime.RoomOptions options = new Photon.Realtime.RoomOptions();
        options.IsOpen = true;
        options.IsVisible = true;
        options.MaxPlayers = maximum_Players;

        PhotonNetwork.JoinOrCreateRoom(roomName, options, TypedLobby.Default);
        start_Button.SetActive(false);
        Status("Joining to " + roomName);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        SceneManager.LoadScene("Game");
    }

    private void Status(string msg)
    {
        Debug.Log(msg);
        status_Text.text = msg;
    }
}
