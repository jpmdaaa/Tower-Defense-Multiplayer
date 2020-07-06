using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Mirror;

public class ButtonsMenu : MonoBehaviour
{

    // Use this for initialization

    public GameObject GO_Room;
    public GameObject GO_Menu;
    public GameObject GO_Options;
    NetworkManager network;

    private void Awake()
    {
        network= (NetworkManager)FindObjectOfType(typeof(NetworkManager));
    }

    public void Playgame()
    {
    
        GO_Menu.SetActive(false);
         GO_Room.SetActive(true);
            GO_Options.SetActive(false);
       


  
    }

    public void Options()
    {
        GO_Menu.SetActive(false);
        GO_Room.SetActive(false);
        GO_Options.SetActive(true);
    }

}
