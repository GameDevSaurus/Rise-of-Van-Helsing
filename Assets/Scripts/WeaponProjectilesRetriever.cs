using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WeaponProjectilesRetriever : MonoBehaviour
{
    
    Weapon weapon;
    public void SetWeapon(Weapon w)
    {
        weapon = w;
    }
    [SerializeField]
    Image im;
    [SerializeField]
    TextMeshProUGUI t;
    void Start()
    {
        
    }

    void Update()
    {
        if (weapon)
        {
            t.text = weapon.GetRemainingProjectiles() + "/" + weapon.GetMagCapacity();
            float amount = (float)weapon.GetRemainingProjectiles() / (float)weapon.GetMagCapacity();
            im.fillAmount = amount;
        }
        
    }
}
