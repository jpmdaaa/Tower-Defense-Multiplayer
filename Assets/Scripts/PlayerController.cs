using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int Life;
    public float Coins;
    //public Slider Slider_Life;
    public Text TXT_Coins;
    public RectTransform rectTransform;
    private GameObject[] children;

    void Start()
    {
        Life = 3;
        Coins = 500;
        rectTransform = GetComponent<RectTransform>();
        //children = GameObject.FindGameObjectsWithTag("CanvasGame");


    }


    void Update()
    {
        /*
        gameObject.transform.parent = children[0].transform ;
        rectTransform.position = new Vector3(960.0f, 540.0f, 0.0f);
        //Slider_Life.value = Life;
        */
        TXT_Coins.text = Coins.ToString("0");
        Coins += Time.time / 600;
        if (Life<=0)
        {

        }
    }
}
