using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string weaponType;
    public float damage;
    PlayerController p;

    private void Start()
    {
        p = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void equip()
    {
        p.currentWeapon = this;
    }

    public virtual void useWeapon()
    {

    }
}
