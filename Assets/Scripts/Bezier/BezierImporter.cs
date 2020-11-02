using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BezierImporter : MonoBehaviour
{

    [SerializeField]
    bool import;
    BezierSpline _bezierSpline;
    [SerializeField]
    string _importData;
    void Start()
    {
        
    }

    void Update()
    {
        if (import)
        {
            _importData = GUIUtility.systemCopyBuffer;
            ZoneData z = JsonUtility.FromJson<ZoneData>(_importData);

            int _enemyCounter = 0;
            for(int i = 0; i< transform.childCount; i++)
            {
                EnemySpawner thisEnemy = transform.GetChild(i).GetComponent<EnemySpawner>();
                if (thisEnemy != null)
                {
                    thisEnemy._enemy =(EnemyType)z._enemyData[_enemyCounter]._enemyType;
                    thisEnemy._maxHP = z._enemyData[_enemyCounter]._maxHP;
                    thisEnemy._damage = z._enemyData[_enemyCounter]._damage;
                    thisEnemy._chaseIndex = z._enemyData[_enemyCounter]._chaseIndex;
                    thisEnemy.animationSpeedOffset = z._enemyData[_enemyCounter]._animationSpeedOffset;
                    thisEnemy.idleSpeedOffset = z._enemyData[_enemyCounter]._idleSpeedOffset;
                    thisEnemy._skin = z._enemyData[_enemyCounter]._skin;
                    thisEnemy._startTaunting = z._enemyData[_enemyCounter]._startTaunting;
                    thisEnemy._preInstantiate = z._enemyData[_enemyCounter]._preInstantiate;
                    thisEnemy._onlyIdle = z._enemyData[_enemyCounter]._onlyIdle;
                    thisEnemy._useRaycast = z._enemyData[_enemyCounter]._useRaycast;
                    thisEnemy._speed = z._enemyData[_enemyCounter]._speed;
                    _enemyCounter++;
                }
            }
            import = false;

        }
    }
}

[System.Serializable]
public class ZoneData
{
    public EnemyData[] _enemyData;
}
[System.Serializable]
public class EnemyData
{
    public int _enemyType;
    public int _maxHP;
    public int _damage;
    public int _chaseIndex;
    public float _animationSpeedOffset;
    public float _idleSpeedOffset;
    public int _skin;
    public bool _startTaunting;
    public bool _preInstantiate;
    public bool _onlyIdle;
    public bool _useRaycast;
    public float _speed;
    public EnemyData(int enemyTime, int maxHP, int damage, int chaseIndex, float animationSpeedOffset, float idleSpeedOffset, int skin, bool startTaunting, bool preInstantiate, bool onlyIdle, bool useRaycast, float speed)
    {
        _enemyType = enemyTime;
        _maxHP = maxHP;
        _damage = damage;
        _chaseIndex = chaseIndex;
        _animationSpeedOffset = animationSpeedOffset;
        _idleSpeedOffset = idleSpeedOffset;
        _skin = skin;
        _startTaunting = startTaunting;
        _preInstantiate = preInstantiate;
        _onlyIdle = onlyIdle;
        _useRaycast = useRaycast;
        _speed = speed;
    }
}

