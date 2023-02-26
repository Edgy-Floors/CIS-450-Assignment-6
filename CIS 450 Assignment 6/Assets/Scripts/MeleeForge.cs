using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeForge : Forge
{

    public override Weapon CreateWeapon(string weapon)
    {
        Weapon w = null;

        if (weapon.Equals("spear"))
        {
            w = new MeleeSpear();
        }
        else if (weapon.Equals("axe"))
        {
            w = new MeleeAxe();
        }
        else if (weapon.Equals("sword"))
        {
            w = new MeleeSword();
        }

        return w;
    }
}
