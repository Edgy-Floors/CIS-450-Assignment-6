using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedForge : Forge
{
    public override Weapon CreateWeapon(string weapon)
    {
        Weapon w = null;

        if(weapon.Equals("bow"))
        {
            w = new RangedBow();
        } else if (weapon.Equals("crossbow"))
        {
            w = new RangedCrossbow();
        } else if(weapon.Equals("gun"))
        {
            w = new RangedGun();
        }

        return w;
    }
}
