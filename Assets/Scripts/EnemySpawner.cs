using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemySpawner : MonoBehaviour
{

    public enum EnemyType {CrawlingNightmare,WalkingNightmare, Zombie, SkeletonZombie, Troll, Werewolf, Explosive, Spitter, Bat, VampireGirl, Hulk}
    [HideInInspector]
    public EnemyType enemy;
    [HideInInspector]
    public int maxHP;
    [HideInInspector]
    public int damage;
    [HideInInspector]
    public int _chaseIndex;
    [HideInInspector]
    public float animationSpeedOffset;
    [HideInInspector]
    public float idleSpeedOffset;
    //[HideInInspector]
    //public EnemyController enemyController;
    [HideInInspector]
    public int _skin;
    [HideInInspector]
    public bool _startTaunting;
    [HideInInspector]
    public bool _preInstantiate;
    [HideInInspector]
    public bool _onlyIdle;
    [HideInInspector]
    public bool _useRaycast;
    [HideInInspector]
    public float _speed;

    public int GetChaseIndex()
    {
        return _chaseIndex;
    }
    public int GetSkin()
    {
        return _skin;
    }
    public float GetIdleSpeed()
    {
        return (1 + idleSpeedOffset);
    }
    public bool GetPreInstantiate()
    {
        return _preInstantiate;
    }
    
    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        return _speed;
    }
    public EnemyType GetEnemyType()
    {
        return enemy;
    }
#if UNITY_EDITOR
    public void OnDrawGizmos()
    {
        int enemyIndex = transform.GetSiblingIndex()-2;
        float finalSpeed = _speed * (1 + animationSpeedOffset);
        transform.name = enemyIndex+"-"+enemy.ToString() + "-" + finalSpeed;
    }
#endif

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
