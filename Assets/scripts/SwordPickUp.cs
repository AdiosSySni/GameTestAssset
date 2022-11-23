using UnityEngine;

public class SwordPickUp : MonoBehaviour
{
    public GameObject EffectHealth;
    public GameObject sword;
    public SwitchWeapon WeaponHandler;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            WeaponHandler.AvailableWeapons.Add(sword);

            Debug.Log(WeaponHandler.AvailableWeapons[1]);
            Debug.Log(WeaponHandler.AvailableWeapons[0]);
            Instantiate(EffectHealth, transform.position, Quaternion.identity);

           
            Destroy(gameObject);
        }
    }
}