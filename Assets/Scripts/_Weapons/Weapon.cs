using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour
{
    [Header("Base Settings")]

    /*
     * @weaponName
     * The name of the weapon.
     */
    [SerializeField]
    private string weaponName;
    public string GetWeaponName() { return weaponName; }
    public void SetWeaponName(string value) => weaponName = value;

}
