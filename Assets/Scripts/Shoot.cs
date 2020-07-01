using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Rigidbody2D bulletPrefabs;
    //public GameObject cursor;
    private Camera cam;
    private Enemy enemy;
    public Transform shootPoint;
    public float ShootVel;
    private Tower tower;
    public float FireRate;
    private float NextFire;

    void Start()
    {
        cam = Camera.main;
        tower = (Tower)FindObjectOfType(typeof(Tower));

    }

    
    void Update()
    {

    }


    void LauchProjectile()
    {
        if(Time.time>NextFire && tower.Posicionada)
        {

        enemy = (Enemy)FindObjectOfType(typeof(Enemy));
        Debug.Log("atirou");
        Vector3 Vo = CalculateVelocity(enemy.transform.position, shootPoint.position, ShootVel);

        Rigidbody2D obj = Instantiate(bulletPrefabs, shootPoint.position, Quaternion.identity);
        obj.velocity= Vo;
        NextFire = Time.time + FireRate;

        }
    }




    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)
    {
        //definindo a distancia x e y primeiro
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;

        //criando variavel float para representar a distancia
        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;

        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;


        Vector3 result = distanceXZ.normalized;

        result *= Vxz;
        result.y = Vy;

        return result;

    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Enemy")
        {
            Debug.Log("achou inimigo");
            tower.anim.SetTrigger("Shoot");
            LauchProjectile();
           
        }
    }


}
