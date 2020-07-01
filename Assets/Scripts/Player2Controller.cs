using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{
    public float Coins;
    public Text TXT_Coins;
    public RectTransform rectTransform;
    private GameObject[] children;

    void Start()
    {
        Coins = 200;
        //rectTransform = GetComponent<RectTransform>();
        //children = GameObject.FindGameObjectsWithTag("CanvasGame");
    }

    
    void Update()
    {
        //rectTransform.position = new Vector3(960.0f, 540.0f, 0.0f);
        //gameObject.transform.parent = children[0].transform;
        TXT_Coins.text = Coins.ToString("0");
        Coins += Time.time /300;
    }
}
