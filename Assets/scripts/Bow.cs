//using UnityEngine;

//public class Bow : MonoBehaviour
//{
//    public GameObject arrow;
//    public Transform shotPoint;
//    private float startKd =2f;
//    public float offset;
//    private float Kd;
//    public Hero hero;

//    void Update()
//    {
//        if (Kd<=0)
//        {
//           if (Input.GetMouseButton(0))
//           {
//                Instantiate(arrow, transform.position, shotPoint.rotation);
//                Kd = startKd;
//           }
//        }
//        else Kd -= Time.deltaTime;
//        FlipBow();
//    }
//    private float FlipBow()
//    {
//        Vector2 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
//        float rotZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
//        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

//        if (hero.facingRight == false)
//        {
//            shotPoint.rotation = Quaternion.Euler(0f, 0f, rotZ - offset);
//            return offset = 0;
//        }
//        else
//        {
//            shotPoint.rotation = Quaternion.Euler(0f, 180f, -rotZ + offset);
//            return offset = 180;
//        }
//    }
//}


using UnityEngine;
//!!!!!!!!!!!!!!!!!!!
public class Bow : MonoBehaviour
{
    public float offset;
    public GameObject arrow;
    public Transform shotPoint;
    private float startKd = 0.5f;
    private float Kd;
 
    void Update()
    {
        Vector2 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ - offset);

        if (Kd <= 0)
        {
            //shotPoint.rotation = Quaternion.Euler(0f, 90f, rotZ - offset);
            if (Input.GetMouseButton(0))
            {
                // Instantiate(bullet, shotPoint.position, shotPoint.rotation);
                Instantiate(arrow, transform.position, transform.rotation);
                Kd = startKd;
            }
        }
        else
        {
            Kd -= Time.deltaTime;
        }

    }
}
