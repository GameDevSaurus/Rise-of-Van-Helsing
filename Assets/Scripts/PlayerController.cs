using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    BezierWalker _bezierWalker;
    [SerializeField]
    Transform _weaponPivot;
    bool shaking;
    Weapon _weapon;
    [SerializeField]
    GameObject _cameraPivot;
    BloodVignetteBehaviour _bloodVignetteBehaviour;
    HitMarksManager _hitMarksManager;
    [SerializeField]
    Animator _grenadeArms;
    [SerializeField]
    Animator _knifeArms;
    [SerializeField]
    Animator _iceArms;
    [SerializeField]
    Animator _potionArms;
    bool healing;
    float healingAmount;
    float healCD = 1;
    float healingRate;
    int _currentHP;
    int _maxHP;
    public int GetCurrentHP()
    {
        return _currentHP;
    }
    public int GetMaxHP()
    {
        return _maxHP;
    }
    public void StartHeal()
    {
        healingRate = 0;
        healingAmount = 0;
        healing = true;
    }
    private void Awake()
    {
        _bloodVignetteBehaviour = FindObjectOfType<BloodVignetteBehaviour>();
        _hitMarksManager = FindObjectOfType<HitMarksManager>();
        _currentHP = 100;
        _maxHP = 100;
    }

    public void UseKnife()
    {
        if (_weapon.GetIdle())
        {
            StartCoroutine(CrUseKnife());
        }
    }
    IEnumerator CrUseKnife()
    {
        _weapon.StopIdle();
        _weapon.Sheathe();
        yield return new WaitForSeconds(0.5f);
        _knifeArms.SetTrigger("Attack");
        yield return new WaitForSeconds(1.5f);
        _weapon.Draw();
    }
    public void ThrowGrenade()
    {
        if (_weapon.GetIdle())
        {
            StartCoroutine(CrThrowGrenade());
        }
    }
    IEnumerator CrThrowGrenade()
    {
        _weapon.StopIdle();
        _weapon.Sheathe();
        yield return new WaitForSeconds(0.5f);
        _grenadeArms.SetTrigger("Play");
        yield return new WaitForSeconds(1.5f);
        _weapon.Draw();
    }
    public void Reload()
    {
        _weapon.Reload();
    }
    public void SetWeapon(Weapon newWeapon)
    {
        _weapon = newWeapon;
    }
    public Transform GetWeaponPivot()
    {
        return _weaponPivot;
    }
    public void Shoot()
    {
        _weapon.Shoot();
    }

    public void Orient()
    {
        _bezierWalker.Orient();
    }
    public void SetPlayerPath(BezierSpline newPlayerPath)
    {
        _bezierWalker.SetPath(newPlayerPath);
    }
    public void Move(int point)
    {
        StartCoroutine(CoMove(point));
    }

    public IEnumerator CoMove(int point)
    {
        yield return _bezierWalker.CoMoveOnePoint(point);
    }
    public void Shake(float duration, float magnitude)
    {
        if (!shaking)
        {
            StartCoroutine(CoShake(duration, magnitude));
        }

    }

    public void End()
    {
        GameEvents.LoadScene.Invoke("Configuration");
    }
    IEnumerator CoShake(float duration, float magnitude)
    {
        shaking = true;
        Vector3 originalPos = _cameraPivot.transform.localPosition;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            _cameraPivot.transform.localPosition = originalPos + new Vector3(x, y, 0);
            elapsed += Time.deltaTime;
            yield return null;
        }
        _cameraPivot.transform.localPosition = originalPos;
        shaking = false;
    }

    public void UseIce()
    {
        StartCoroutine(CrUseIce());
    }
    IEnumerator CrUseIce()
    {
        _weapon.Sheathe();
        yield return new WaitForSeconds(0.5f);
        _iceArms.SetTrigger("Play");
        yield return new WaitForSeconds(0.8f);
        CurrentSceneController.SetGameSpeed(0.25f);
        yield return new WaitForSeconds(0.6f);
        _weapon.Draw();
        yield return new WaitForSeconds(10);
        CurrentSceneController.SetGameSpeed(1f);
    }
    public void UsePotion()
    {
        StartCoroutine(CrUsePotion());
    }
    IEnumerator CrUsePotion()
    {
        _weapon.Sheathe();
        yield return new WaitForSeconds(0.5f);
        _potionArms.SetTrigger("Play");
        yield return new WaitForSeconds(1.5f);
        _weapon.Draw();
    }
    
    public void ReceiveHit(int damage)
    {
        _currentHP -= damage;
        _bloodVignetteBehaviour.EnableBlood();
        Shake(0.1f, 0.3f);
    }

    public void ReceiveHit(int damage,EnemyAttackTypes attackType,EnemyAttackDirections attackDirections, Vector3 pos)
    {
        _currentHP -= damage;
        _hitMarksManager.ShowHitMark(attackType, attackDirections, pos);
        _bloodVignetteBehaviour.EnableBlood();
        Shake(0.1f, 0.3f);
    }
    void Update()
    {
        if (healing)
        {
            healingAmount += 30 * Time.deltaTime;
            _currentHP += (int)healingAmount;
            _currentHP = Mathf.Min(_currentHP, _maxHP);
            healingAmount -= (int)healingAmount;
            healingRate += Time.deltaTime;
            if (healingRate > healCD)
            {
                healing = false;
            }

        }
    }
}
