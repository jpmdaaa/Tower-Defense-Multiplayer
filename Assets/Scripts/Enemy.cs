using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life;
    public float speed;
    public int Damage;
    public int value;

    private AirPoints airpoints;
    private int airpointIndex;
    //private PlayerController Player;

    void Start()
    {
        airpoints = GameObject.FindGameObjectWithTag("AirPoint").GetComponent<AirPoints>();
        //Player = (PlayerController)FindObjectOfType(typeof(PlayerController));

    }
    void Update()
    {
        Moviment();
        TestLife();

    }


    void Moviment()
    {
        transform.position = Vector2.MoveTowards(transform.position, airpoints.Airpoints[airpointIndex].position, speed * Time.deltaTime);
        Vector3 dir = airpoints.Airpoints[airpointIndex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Vector2.Distance(transform.position, airpoints.Airpoints[airpointIndex].position) < 0.1f)
        {


            if (airpointIndex < airpoints.Airpoints.Length - 1)
            {
                airpointIndex++;
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }

    void DamagePlayer()
    {
       // Player.Life -= Damage;
        

    }

    void TestLife()
    {
        if(life<=0)
        {
          //  Player.Coins += value;
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.tag == "finish")
        {
           
            DamagePlayer();
            Destroy(gameObject);
        }


        if(collision.gameObject.tag == "shoot")
        {
            life -= collision.gameObject.GetComponent<Bullet>().damage;
         
            
            Destroy(collision.gameObject);

        }

        if(collision.gameObject.tag=="Enemy")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        }
    }
    
}
