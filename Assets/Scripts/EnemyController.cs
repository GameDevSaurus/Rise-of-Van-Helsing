using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    int _maxHP;
    int _currentHP;
    int _damage;
    float _chaseSpeed;
    int _chaseIndex;
    int _skin;
    float _idleSpeed;

    [SerializeField]
    EnemyType _enemyType;    
    [SerializeField]
    GameObject _head;
    [SerializeField]
    GameObject _leftHand;
    [SerializeField]
    GameObject _rightHand;
    [SerializeField]
    SpecificEnemyBehaviour _specificEnemyBehaviour;
    [SerializeField]
    Transform _healthBarPosition;
    PlayerController _playerController;
    bool dead;
    public void SetPlayerController(PlayerController newPlayerController)
    {
        _playerController = newPlayerController;
    }
    public void Init()
    {
        _specificEnemyBehaviour.Init();
    }
    public void ReceiveHit(int damage, bool headshot, GameObject hittedGameObject, Vector3 hitDirection)
    {
        if (!dead)
        {
            _currentHP -= damage;
            if (_currentHP <= 0)
            {
                _specificEnemyBehaviour.Die(hittedGameObject.GetComponent<Rigidbody>(), hitDirection.normalized);
                dead = true;
                CurrentSceneController._kills++;
            }
            if (headshot)
            {
                _specificEnemyBehaviour.ReceiveHit();
            }
            else
            {
                _specificEnemyBehaviour.ReceiveHit();
            }
        }

        
    }
    public void AttackPlayer(EnemyAttackTypes attackType, EnemyAttackParts attackPart, EnemyAttackDirections attackDirections)
    {
        Vector3 attackPos = transform.position;
        switch (attackPart)
        {
            case EnemyAttackParts.Head:
                attackPos = _head.transform.position;
                break;

            case EnemyAttackParts.LeftHand:
                attackPos = _leftHand.transform.position;
                break;

            case EnemyAttackParts.RightHand:
                attackPos = _rightHand.transform.position;
                break;
        }
        _playerController.ReceiveHit(_damage,attackType, attackDirections, attackPos);
    }
    public void AttackPlayer()
    {
        _playerController.ReceiveHit(_damage);
    }
    public void SetPath(BezierSpline newPath)
    {
        _specificEnemyBehaviour.SetPath(newPath);
    }
    public void Orient()
    {
        _specificEnemyBehaviour.Orient();
    }
    public void SetIdleSpeed(float newIdleSpeed)
    {
        _idleSpeed = newIdleSpeed;
    }
    public void SetSkin(int newSkin)
    {
        _specificEnemyBehaviour.SetSkin(newSkin);
    }

    public int GetChaseIndex()
    {
        return _chaseIndex;
    }

    public void SetChaseIndex(int newChaseIndex)
    {
        _chaseIndex = newChaseIndex;
        _specificEnemyBehaviour.SetChaseIndex(newChaseIndex);
    }
    public void SetChaseAnimationSpeedOffset(float chaseAnimationSpeedOffset)
    {

        _specificEnemyBehaviour.SetChaseAnimationSpeedOffset(chaseAnimationSpeedOffset);
    }
    public float GetChaseSpeed()
    {
        return _chaseSpeed;

    }

    public void SetChaseSpeed(float newChaseSpeed)
    {
        _chaseSpeed = newChaseSpeed;
        _specificEnemyBehaviour.SetSpeed(newChaseSpeed);
    }
    public int GetDamage()
    {
        return _damage;
    }

    public void SetDamage(int newDamage)
    {
        _damage = newDamage;
    }
    public int GetCurrentHP()
    {
        return _currentHP;
    }

    public void SetCurrentHP(int newCurrenthp)
    {
        _currentHP = newCurrenthp;
    }

    public int GetMaxHP()
    {
        return _maxHP;
    }
    public void SetMaxHp(int newMaxHP)
    {
        _maxHP = newMaxHP;
    }

    public EnemyType GetEnemyType()
    {
        return _enemyType;
    }
    public void SetEnemyType(EnemyType newEnemyType)
    {
        _enemyType = newEnemyType;
    }
}


