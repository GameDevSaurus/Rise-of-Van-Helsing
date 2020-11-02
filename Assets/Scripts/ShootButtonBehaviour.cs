using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButtonBehaviour : MonoBehaviour
{
    PlayerController _playerController;
    bool shooting;    
    public void SetPlayer(PlayerController playerController)
    {
        _playerController = playerController;
    }
    
    public void ShootButtonUp()
    {
        shooting = false;
    }

    public void ShootButtonDown()
    {
        shooting = true;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        if (shooting)
        {
            _playerController.Shoot();
        }
    }
}
