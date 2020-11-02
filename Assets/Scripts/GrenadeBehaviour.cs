using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBehaviour : MonoBehaviour
{
    ParticleSystem[] pss;
    [SerializeField]
    GameObject grenade;
    [SerializeField]
    GameObject impostorGrenade;

    [SerializeField] private GameObject rightHand;

    public void GrenadeExplosionCallback()
    {

        GameObject g = Instantiate(grenade, impostorGrenade.transform.position, impostorGrenade.transform.rotation);
        Rigidbody rb = g.GetComponent<Rigidbody>();
        pss = g.GetComponentsInChildren<ParticleSystem>();
        rb.velocity = (Camera.main.transform.forward*2 + Vector3.up ).normalized * 15;
        rb.AddTorque(3, 4, 5);
        StartCoroutine(Explode(g));
        
    }

    public void GrenadeThrow()
    {
        
    }

    IEnumerator Explode(GameObject g)
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < pss.Length; i++)
        {
            pss[i].gameObject.transform.parent = null;
            pss[i].gameObject.transform.position = pss[i].transform.position + Vector3.up;
            pss[i].Play();
        }

        List<GameObject> nearEnemies = new List<GameObject>();
        foreach (Collider c in Physics.OverlapSphere(g.transform.position, 5, 1 << 9))
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
                //en.GetComponentInChildren<GroundMeleeEnemyBehaviour>().gameObject.transform.root.LookAt(new Vector3(g.transform.position.x, en.transform.root.position.y, g.transform.position.z));
                //en.GetComponentInChildren<GroundMeleeEnemyBehaviour>().ReceiveHit(1000);
                CurrentSceneController._kills++;
                en.GetComponentInChildren<SpecificEnemyBehaviour>().DieByExplosion(transform.position);
            }
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
