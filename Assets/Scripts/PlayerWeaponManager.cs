using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{

    public Transform transformRightHand;
    public GameObject EquippedWeapon { get; set; }
    IWeapon equippedIWeapon;

    CharacterStats playerCharacterStats;

    void Start()
    {
        playerCharacterStats = GetComponent<CharacterStats>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PerformAttack();
        }
    }

    public void EquipWeapon(Item _Item)
    {
        if (_Item == null) return;

        if (EquippedWeapon != null)
        {
            playerCharacterStats.RemoveStatBonus(equippedIWeapon.Stats);
            Destroy(transformRightHand.GetChild(0).gameObject);
        }

        GameObject Weapon = Resources.Load<GameObject>("Weapons/" + _Item.ObjectSlug);

        if (Weapon == null)
        {
            Debug.Log("Weapon == NULL (Resources.Load failed to find a GameObject)");
            return;
        }

        EquippedWeapon = (GameObject)Instantiate(Weapon, transformRightHand.position, Weapon.transform.rotation);
        EquippedWeapon.transform.SetParent(transformRightHand);

        equippedIWeapon = EquippedWeapon.GetComponent<IWeapon>();

        if (equippedIWeapon != null)
            equippedIWeapon.Stats = _Item.Stats;

        playerCharacterStats.AddStatBonus(_Item.Stats);

    }

    public void PerformAttack()
    {
        if (equippedIWeapon != null)
            equippedIWeapon.Attack();
        else
            Debug.Log("equippedIWeapon == NULL");
    }
}
