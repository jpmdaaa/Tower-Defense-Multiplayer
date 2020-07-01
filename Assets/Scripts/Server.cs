using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Server : MonoBehaviour
{
    
    public bool Player1;
    public bool Player2;

    public GameObject GO_Interface_P1;
    public GameObject GO_Interface_P2;

    //public GameObject GO_FinishGame;

    public bool Player1Win;
    public bool Player2Win;
   
    
    void Start()
    {
    
    }

   
    void Update()
    {
        Debug.Log("Server active: " + NetworkServer.active);

    }

    public GameObject GetPlayer1()
    {
        return GO_Interface_P1;
    }

    public GameObject GetPlayer2()
    {
        return GO_Interface_P2;
    }



    public void SetPlayer1()
    {
        GO_Interface_P1.SetActive(true);
   
    }

    public void SetPlayer2()
    {
        GO_Interface_P2.SetActive(true);
    }

}
