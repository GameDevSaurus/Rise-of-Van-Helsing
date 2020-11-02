using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBehaviour : MonoBehaviour
{

    

    public void PotionExplodeCallback()
    {
        FindObjectOfType<HealHudManager>().Heal();
        FindObjectOfType<PlayerController>().StartHeal();
    }

    void Update()
    {

    }
}
