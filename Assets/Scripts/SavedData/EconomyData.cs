using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EconomyData
{
    public int _softCoins;
    public int _hardCoins;
    public int _blood;
    public int _materials;
    public int _souls;
    public int _scrap;

    public EconomyData()
    {
        _softCoins = 0;
        _hardCoins = 0;
        _blood = 8;
        _materials = 0;
        _souls = 0;
        _scrap = 65;
    }

}
