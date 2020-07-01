using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
public class ReturnMenu : MonoBehaviour
{

    NetworkManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = (NetworkManager)FindObjectOfType(typeof(NetworkManager));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Return()
    {
        SceneManager.LoadScene(0);
        manager.StopClient();
    }
}
