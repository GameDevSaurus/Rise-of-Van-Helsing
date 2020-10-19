using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSceneController : MonoBehaviour
{
    public static int _kills;
    public static float _elapsedTime;
    public static float _currentGameSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        _elapsedTime += Time.deltaTime * _currentGameSpeed;
    }
}
