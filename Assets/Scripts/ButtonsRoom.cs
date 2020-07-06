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
    NetworkConnectionToClient conClient;
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

        // client ready
        if (NetworkClient.isConnected && !ClientScene.ready)
        {
                ClientScene.Ready(NetworkClient.connection);

                if (ClientScene.localPlayer == null)
                {
                    ClientScene.AddPlayer(NetworkClient.connection);
                }
            
        }




        //Debug.Log("Server active: " + NetworkServer.active);
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

                //inicia o host, client + servidor
                manager.StartHost();
               
                //ativa a interface do p1
                serverTest.SetPlayer1();
                
                //adiciona o jogador ao servidor
                NetworkServer.AddPlayerForConnection(conn, serverTest.GetPlayer1());
            
               //ativa mensagem de esperando outro jogar
                Waiting.SetActive(true);
               

            }


            if (type == 2)
            {
                //inicia o host, client 
                manager.StartClient();
                //ativa a interface do p1
                serverTest.SetPlayer2();
                //adiciona o jogador ao servidor
                NetworkServer.AddPlayerForConnection(conn, serverTest.GetPlayer2());
                Debug.Log(NetworkServer.active);

                GO_Game.SetActive(true);
                 GO_Room.SetActive(false);

                    

            }
            manager.networkAddress = "LocalHost";

            


        }
        else
        {
            // Connecting
            Debug.Log("Connecting to " + manager.networkAddress + "..");

            manager.StopClient();
            
        }

    }
  
}
