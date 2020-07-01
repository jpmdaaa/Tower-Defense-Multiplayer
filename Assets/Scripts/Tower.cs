using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Tower : MonoBehaviour
{
    private Transform TR;
    //private BoxCollider2D Collider;
    public bool Posicionada;
    private bool PodePosicionar;
    public Animator anim;
    private Server testplayer;

    void Start()
    {
        TR = GetComponent<Transform>();
        //Collider = GetComponent<BoxCollider2D>();
        Posicionada = false;
        PodePosicionar = false;
        anim = GetComponent<Animator>();
        testplayer = (Server)FindObjectOfType(typeof(Server));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Posicionada == false && testplayer.Player1)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            TR.position = new Vector2(cursorPos.x, cursorPos.y);
            //Collider.enabled = false;
        }
        //else
           //Collider.enabled = true;

        if(Input.GetMouseButtonDown(0) && PodePosicionar)
        {
            Posicionada = true;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PointTower")
        {
            PodePosicionar = true;

            Debug.Log("PODE POSICIONAR");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PointTower")
        {
            PodePosicionar = false;
            Debug.Log("NAO PODE POSICIONAR");
        }
    }

   

}
