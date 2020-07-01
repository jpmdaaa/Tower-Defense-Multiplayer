using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    
    void Start()
    {
        
    }

    
    void Update()
    {
      if(gameObject.transform.position.y<-5)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
   
        if(collision.gameObject.tag == "Tower" )
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        }
        if (collision.gameObject.tag == "shoot")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        }

        if (collision.gameObject.tag == "PointTower")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
           


        }

        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
        }


        //Destroy(gameObject);
    }
}
