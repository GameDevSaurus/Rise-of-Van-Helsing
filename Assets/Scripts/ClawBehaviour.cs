using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawBehaviour : MonoBehaviour
{
    public void AttackCallback()
    {
        List<GameObject> nearEnemies = new List<GameObject>();
        foreach (Collider c in Physics.OverlapSphere(Camera.main.transform.position, 6, 1 << 9))
        {
            if (!nearEnemies.Contains(c.gameObject.transform.root.gameObject))
            {
                nearEnemies.Add(c.gameObject.transform.root.gameObject);
            }
        }
        foreach (GameObject en in nearEnemies)
        {
            if (en.GetComponentInChildren<EnemyController>() != null)
            {
                CurrentSceneController._kills++;
                en.GetComponentInChildren<SpecificEnemyBehaviour>().DieByKnife(transform.position);
                //VFXPool blood = GameObject.Find("VFXBloodExplosionPool").GetComponent<VFXPool>();
                //blood.Play(en.transform.position + Vector3.up*2);
            }
        }

    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
