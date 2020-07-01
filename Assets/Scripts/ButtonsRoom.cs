using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;

public class ButtonsRoom : MonoBehaviour
{

    public GameObject GO_Room;
    public GameObject GO_Game;
    private Server serverTest;
    NetworkManager manager;
    NetworkConnection conn;
    public GameObject Waiting;
    public Text numberPlayer;

    private Server servertest;

    private void Awake()
    {
        manager = (NetworkManager)FindObjectOfType(typeof(NetworkManager));
        serverTest = (Server)FindObjectOfType(typeof(Server));
        Debug.Log("Numero de jogadores: " + manager.numPlayers);
        servertest = (Server)FindObjectOfType(typeof(Server));

    }

    private void Update()
    {
        //Debug.Log("Numero de jogadores: " + manager.numPlayers);

        numberPlayer.text = ("Numero de jogadores: " + manager.numPlayers);

        if (manager.numPlayers == 2)
        {
            GO_Game.SetActive(true);
            GO_Room.SetActive(false);
            servertest.Player1 = true;
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            manager.StopClient();
            Waiting.SetActive(false);

        }
        
    }


    public void RoomManager(int type)
    {
        if (!NetworkClient.active)
        {
        
            if (type == 1 )
            {
                manager.StartHost();
             
                serverTest.SetPlayer1();
              
                NetworkServer.AddPlayerForConnection(conn, serverTest.GetPlayer1());
             
                Waiting.SetActive(true);
               

            }


            if (type == 2 && NetworkServer.active)
            {
                 
                    manager.StartClient();
                    
                    serverTest.SetPlayer2();
                    NetworkServer.AddPlayerForConnection(conn, serverTest.GetPlayer2());
                    GO_Game.SetActive(true);
                    GO_Room.SetActive(false);

                    

            }

            if (manager.numPlayers != 2)
            {
             
             
            }


        }
        else
        {
            // Connecting
            Debug.Log("Connecting to " + manager.networkAddress + "..");
          
                //manager.StopClient();
            
        }

    }
  
}
