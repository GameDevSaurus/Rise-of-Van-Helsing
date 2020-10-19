using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelsProgressionData 
{
    public bool[] _levelsProgressionData;

    public int _baseAssaults;

    public LevelsProgressionData()
    {
        _levelsProgressionData = new bool[200];
        _baseAssaults = 0;
    }
}
