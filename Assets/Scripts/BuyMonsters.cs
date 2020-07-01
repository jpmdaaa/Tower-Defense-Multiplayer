using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class BuyMonsters : MonoBehaviour
{

    private Player2Controller Player;
    public int[] EnemyCost;
    public GameObject[] Enemys;
    NetworkManager manager;
  
    private void Start()
    {
        Player = (Player2Controller)FindObjectOfType(typeof(Player2Controller));
        manager = (NetworkManager)FindObjectOfType(typeof(NetworkManager));

    }


    public void BuyTower_1()
    {
        if (Player.Coins >= EnemyCost[0])
        {
            Player.Coins -= EnemyCost[0];

            Enemys[0] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Enemy1"));
            NetworkServer.Spawn(Enemys[0]);

        }

    }
    public void BuyTower_2()
    {
        if (Player.Coins >= EnemyCost[1])
        {
            Player.Coins -= EnemyCost[1];
            Enemys[1] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Enemy2"));
            NetworkServer.Spawn(Enemys[1]);
        }

    }
    public void BuyTower_3()
    {
        if (Player.Coins >= EnemyCost[2])
        {
            Player.Coins -= EnemyCost[2];
            Enemys[2] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Enemy3"));
            NetworkServer.Spawn(Enemys[2]);
        }
    }
    public void BuyTower_4()
    {
        if (Player.Coins >= EnemyCost[3])
        {
            Player.Coins -= EnemyCost[3];
            Enemys[3] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Enemy4"));
            NetworkServer.Spawn(Enemys[3]);
        }
    }
    public void BuyTower_5()
    {
        if (Player.Coins >= EnemyCost[4])
        {
            Player.Coins -= EnemyCost[4];
            Enemys[4] = Instantiate(manager.spawnPrefabs.Find(prefab => prefab.name == "Enemy5"));
            NetworkServer.Spawn(Enemys[4]);
        }
    }

}
