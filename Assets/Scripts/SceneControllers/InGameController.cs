using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InGameController : MonoBehaviour
{
    public GameObject _player;
    private void Start()
    {
        GameEvents.StartLevel.AddListener(StartPlayingLevel);
    }

    public void StartPlayingLevel()
    {
        _player.SetActive(true);
    }

}
