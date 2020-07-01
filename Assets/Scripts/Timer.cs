using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float timer;
    public Text TXT_timer;
    private Server server;
    public GameObject[] fase;
    void Start()
    {
        server = (Server)FindObjectOfType(typeof(Server));
        timer = 180;
    }

    void Update()
    {
        if(timer>0)
        {
            timer -= Time.deltaTime;
            
            
        }

        if(timer<=0)
        {
            /*
            if(fase[0].active)
            {
                fase[0].SetActive(false);
                fase[1].SetActive(true);
            }

            if (fase[1].active)
            {
                fase[1].SetActive(false);
                fase[2].SetActive(true);
            }

            if (fase[2].active)
            {
                fase[2].SetActive(false);
                fase[3].SetActive(true);
            }

    */
            timer =180;
        }
        
        


        TXT_timer.text = timer.ToString("0");

    }
}
