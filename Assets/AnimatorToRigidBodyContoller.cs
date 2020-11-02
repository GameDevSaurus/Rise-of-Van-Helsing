using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorToRigidBodyContoller : MonoBehaviour
{
    [SerializeField]
    Animator _animator;
    [SerializeField]
    Collider[] _colliders;
    [SerializeField]
    Rigidbody[] _rigidBodies;
    void Start()
    {
        _animator.enabled = true;
        SetCollidersTrigger(true);
        SetRigidBodiesKinematic(true); 
    }

    public void SetCollidersTrigger(bool newTriggerState)
    {
        foreach (Collider c in _colliders)
        {
            c.isTrigger = newTriggerState;
        }
    }

    public void SetRigidBodiesKinematic(bool newKinematicState)
    {
        foreach (Rigidbody rb in _rigidBodies)
        {
            rb.isKinematic = newKinematicState;
        }
    }

    public void Die(Rigidbody damagedRigidBody, Vector3 hitDirection)
    {
        _animator.enabled = false;
        SetCollidersTrigger(false);
        SetRigidBodiesKinematic(false);
        damagedRigidBody.AddForce(hitDirection * 40, ForceMode.Impulse);
    }
    public void DieByExplosion(Vector3 pos)
    {
        _animator.enabled = false;
        SetCollidersTrigger(false);
        SetRigidBodiesKinematic(false);
        _rigidBodies[0].AddForce((_rigidBodies[0].position-pos).normalized * 50 + Vector3.up*50, ForceMode.Impulse);
    }
    public void DieByKnife(Vector3 pos)
    {
        _animator.enabled = false;
        SetCollidersTrigger(false);
        SetRigidBodiesKinematic(false);
        _rigidBodies[0].AddForce((_rigidBodies[0].position - pos).normalized * 50, ForceMode.Impulse);
    }


}
