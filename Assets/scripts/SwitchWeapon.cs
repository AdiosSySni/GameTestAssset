using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public List<GameObject> AvailableWeapons;
    public GameObject currentWeapon;
    //public GameObject nextWeapon;

    private void Start()
    {
        AvailableWeapons.Add(currentWeapon);        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < AvailableWeapons.Count; i++)
            {
                if (AvailableWeapons[i].activeInHierarchy == true)
                {
                    AvailableWeapons[i].SetActive(false);
                    Debug.Log("1");
                }

                else
                {
                    AvailableWeapons[AvailableWeapons.Count - 1].SetActive(true);
                    Debug.Log("2");
                }
            }
        }
    }
}
