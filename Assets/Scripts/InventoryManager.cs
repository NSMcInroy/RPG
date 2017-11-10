using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    PlayerWeaponManager playerWeaponManager;

    public Item sword;

    void Start()
    {
        playerWeaponManager = GetComponent<PlayerWeaponManager>();
        List<BaseStat> _SwordStats = new List<BaseStat>();
        _SwordStats.Add(new BaseStat(3, "Power", "Your power level."));
        _SwordStats.Add(new BaseStat(2, "Vitality", "Your vitality level."));

        sword = new Item(_SwordStats, "Sword");
    }

    void  Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerWeaponManager.EquipWeapon(sword);
        }
    }
}
