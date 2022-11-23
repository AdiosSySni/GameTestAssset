//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class bullet : MonoBehaviour
//{
//    private Rigidbody2D rb;

//    private float speed = 15f;
//    private int damage = 20;

//    private int life = 0;
//    public LayerMask whatIsLayer;
//    private int lifeMax = 500;

//    public Bow bowScript;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        //rb.velocity = new Vector2(speed, rb.velocity.y);
//        rb.velocity = transform.right * speed;
//    }

//    void Update()
//    {
//        life++;

//        if (life >= lifeMax)
//        {
//            Explode(); //Если снаряд пролетел определённое расстояние и ни с чем не столкнулся, его нужно удалить, чтобы он не расходовал ресурсы
//        }
//    }

//    void OnTriggerEnter2D(Collider2D hitInfo) //Метод, который срабатывает при попадании
//    {
//        Explode();
//    }

//    void Explode()
//    {
//        Destroy(gameObject); //Уничтожение объекта
//    }

//    //private void FlipBullet()
//    //{

//    //}
//}


using UnityEngine;
//!!!!!!!!!!!!
public class bullet : MonoBehaviour
{
    private float speed = 30f;
    private int damage = 5;
    private float distance = 0;
    private int lifetime = 10;
    public LayerMask whatIsSolid;
    public GameObject destroyEffect;

    void Start()
    {
        Invoke("DestroyBullet", lifetime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        Debug.DrawRay(transform.position, transform.up, Color.red);

        if (hitInfo.collider != null)
        {

            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<EnemyScript>().ChangeHealthEnemy(-damage);
                Debug.Log("HitEnemy");
                Instantiate(destroyEffect, transform.position, Quaternion.identity);
                DestroyBullet();
            }
            if (hitInfo.collider.CompareTag("ground"))
            {
                Instantiate(destroyEffect, transform.position, Quaternion.identity);
                DestroyBullet();
                Debug.Log("HitGround");
            }
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}

