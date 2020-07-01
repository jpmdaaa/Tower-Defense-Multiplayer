using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class BuyTower : MonoBehaviour
{

    private PlayerController Player;
    public int[] towerCost;
    public GameObject[] Towers;
    NetworkManager manager;

    private void Start()
    {
        Player = (PlayerController)FindObjectOfType(typeof(PlayerController));
        manager = (NetworkManager)FindObjectOfType(typeof(NetworkManager));
    }


    public void BuyTower_1()
    {
        if(Player.Coins>=towerCost[0])
        {
            Player.Coins -= towerCost[0];
            Towers[0] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Tower1"));
            NetworkServer.Spawn(Towers[0]);
        }
      
    }
    public void BuyTower_2()
    {
        if (Player.Coins >= towerCost[1])
        {
            Player.Coins -= towerCost[1];
            Towers[1] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Tower2"));
            NetworkServer.Spawn(Towers[1]);
        }

    }
    public void BuyTower_3()
    {
        if (Player.Coins >= towerCost[2])
        {
            Player.Coins -= towerCost[2];
            Towers[2] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Tower3"));
            NetworkServer.Spawn(Towers[2]);
        }
    }
    public void BuyTower_4()
    {
        if (Player.Coins >= towerCost[3])
        {
            Player.Coins -= towerCost[3];
            Towers[3] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Tower4"));
            NetworkServer.Spawn(Towers[3]);
        }
    }


}
