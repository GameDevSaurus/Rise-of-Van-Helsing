using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    Animator _weaponAnimator;
    [SerializeField]
    float _shootSpeed;
    bool _isIdle;
    bool _canShoot;
    int _remainingProjectiles;
    [SerializeField]
    int _magCapacity;
    [SerializeField]
    Transform _shootOrigin;
    [SerializeField]
    int _damage;
    LineRendererPool _lineRendererPool;
    VFXPool _vfxBloodPool;

    public bool GetIdle()
    {
        return _isIdle;
    }
    public void StopIdle()
    {
        _isIdle = false;
    }
    public void Draw()
    {
        _weaponAnimator.SetTrigger("Draw");
    }
    public void Sheathe()
    {
        _weaponAnimator.SetTrigger("Sheathe");
    }
    public void SetVfxBloodPool(VFXPool newVFXPool)
    {
        _vfxBloodPool = newVFXPool;
    }
    public void SetLineRendererPool(LineRendererPool newLineRendererPool)
    {
        _lineRendererPool = newLineRendererPool;
    }
    private void Start()
    {
        _canShoot = true;
        _remainingProjectiles = _magCapacity;
    }
    public int GetRemainingProjectiles()
    {
        return _remainingProjectiles;
    }
    public int GetMagCapacity()
    {
        return _magCapacity;
    }
    public void Shoot()
    {
        if (_isIdle)
        {
            if (_canShoot)
            {
                _weaponAnimator.SetTrigger("Shoot");
                _canShoot = false;
                StartCoroutine(CrRestoreShoot());
            }
        }
    }
    IEnumerator CrRestoreShoot()
    {
        float time = 1f / _shootSpeed;
        yield return new WaitForSeconds(time);
        _canShoot = true;
    }
    public void ShootCallback()
    {
        CreateShoot();
    }

    public void CreateShoot()
    {
        _remainingProjectiles--;
        RaycastHit hit;
        Vector3 raycastOrigin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(Camera.main.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0)), Camera.main.transform.forward, out hit))
        {
            _lineRendererPool.Shoot(_shootOrigin.position, hit.point);

            if (hit.collider.gameObject.layer == 9)
            {
                _vfxBloodPool.Play(hit.point);
                int finalDamage = _damage;
                bool headshot = false;
                if (hit.collider.gameObject.CompareTag("Head"))
                {
                    finalDamage *= 2;
                    headshot = true;
                }
                hit.collider.transform.root.GetComponent<EnemyController>().ReceiveHit(finalDamage, headshot, hit.collider.gameObject,hit.point-_shootOrigin.position);
            }
        }
        else
        {
            _lineRendererPool.Shoot(_shootOrigin.position, _shootOrigin.position + Camera.main.transform.forward * 100);
        }

    }
    private void Update()
    {
    }
    public void StartIdle()
    {
        if (_remainingProjectiles <= 0)
        {
            Reload();
        }
        else
        {
            _isIdle = true;
        }

    }
    void ReloadCallback()
    {
        _remainingProjectiles = _magCapacity;
    }
    public void Reload()
    {
        _weaponAnimator.SetTrigger("Reload");
    }
}
