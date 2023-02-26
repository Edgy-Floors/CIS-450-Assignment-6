using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Forge : MonoBehaviour
{
    private void Start()
    {
        displayPoint = GameObject.Find("DisplayPoint");
    }

    public GameObject displayPoint;
    public abstract Weapon CreateWeapon(string weapon);

    public Weapon ShowWeapon(string weapon)
    {
        Weapon w;
        w = CreateWeapon(weapon);
        Instantiate(w, displayPoint.transform);
        return w;
    }
}
