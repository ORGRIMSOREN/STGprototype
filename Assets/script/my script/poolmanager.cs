using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolmanager : MonoBehaviour
{
    [SerializeField]weapon[] playerProjectWeapon;


    private void Start()
    {
        Initalize(playerProjectWeapon);
    }

    void Initalize(weapon[]weapons)
    {
        foreach (var weapon in weapons)
        {
           Transform poolParent= new GameObject("weapon:" + weapon.prefab.name).transform;
            poolParent.parent = transform;
            weapon.Initialize(poolParent);

        }
    }
}
