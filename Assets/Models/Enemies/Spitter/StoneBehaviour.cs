using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBehaviour : MonoBehaviour
{
    int damage;
    Vector3 tg;
    Vector3 BallisticVel(Vector3 target, float a)
    {
        //Vector3 updatedTarget = transform.position + ((target - transform.position).normalized*((target - transform.position).magnitude)-);
        Vector3 dir = target - transform.position;
        float heightDifference = dir.y;
        dir = new Vector3(dir.x, 0, dir.z);
        float distance = dir.magnitude; //horizontal distance
        var angle = a * Mathf.Deg2Rad;
        dir = new Vector3(dir.x, Mathf.Tan(angle) * distance, dir.z);
        distance += heightDifference / Mathf.Tan(angle);
        float velocity = Mathf.Sqrt(distance * Physics.gravity.magnitude / Mathf.Sin(2 * angle));
        return velocity * dir.normalized;
    }

    public void Throw(Vector3 target, int dmg)
    {
        tg = target;
        damage = dmg;
        GetComponent<Rigidbody>().velocity = BallisticVel(target, 30);
        GetComponent<Rigidbody>().AddTorque(new Vector3(0, 0, 180), ForceMode.Impulse);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance2player = Mathf.Abs((transform.position - tg).magnitude);
        if (distance2player < 1)
        {
            //FindObjectOfType<PlayerManager>().ReceiveHit(damage);
            Destroy(transform.root.gameObject);
        }
    }
}
