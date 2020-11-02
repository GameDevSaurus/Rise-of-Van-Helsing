using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HPBarBehaviour : MonoBehaviour
{
    [SerializeField]
    Image hpBarFront;
    PlayerController _playerController;
    [SerializeField]
    Text t;
    

    public void SetPlayerController(PlayerController newPlayerController)
    {
        _playerController = newPlayerController;
    }

    void Update()
    {
        //hpBarFront.rectTransform.sizeDelta = new Vector2(750 * (float)playerStats.GetCurrentHP() / (float)playerStats.GetMaxHp(), 33);
        hpBarFront.fillAmount = (float)_playerController.GetCurrentHP() / (float)_playerController.GetMaxHP();
        t.text = _playerController.GetCurrentHP() + " / " + _playerController.GetMaxHP();
    }
    
}
