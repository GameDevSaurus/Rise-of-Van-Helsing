using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserData 
{
    public int _IDPlayer;
    public string _playerName;
    public int _experience;

    public UserData()
    {
        _IDPlayer = 0;
        _playerName = "Player Name";
        _experience = 500;
    }
}
