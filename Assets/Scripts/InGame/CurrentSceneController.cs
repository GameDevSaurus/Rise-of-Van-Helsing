using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSceneController : MonoBehaviour
{
    public static int _kills;
    public static float _elapsedGameTime;
    public static float _currentGameSpeed;
    public bool _canCountTime;
    private void Awake()
    {
        GameEvents.StartLevel.AddListener(CanCountTime);
    }
    public static void SetGameSpeed(float newGameSpeed)
    {
        _currentGameSpeed = newGameSpeed;
    }
    public void CanCountTime()
    {
        _canCountTime = true;
    }
    void Start()
    {
        _currentGameSpeed = 1;
    }

    void Update()
    {
        if (_canCountTime)
        {
            _elapsedGameTime += Time.deltaTime * _currentGameSpeed;
        }
    }
}
