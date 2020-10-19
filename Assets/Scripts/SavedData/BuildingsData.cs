using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BuildingsData
{
    public List<BuildingInfo> _buildings;
    public BuildingsData()
    {
        _buildings = new List<BuildingInfo>();
        _buildings.Add(new BuildingInfo(0, "Cathedral", 1));
        _buildings.Add(new BuildingInfo(1, "BloodShrine", 0));
        _buildings.Add(new BuildingInfo(2, "Warehouse", 0));
        _buildings.Add(new BuildingInfo(3, "Mine", 0));
        _buildings.Add(new BuildingInfo(4, "Forge", 0));
        _buildings.Add(new BuildingInfo(5, "Graveyard", 0));
        _buildings.Add(new BuildingInfo(6, "Crypt", 0));
        _buildings.Add(new BuildingInfo(7, "Dragon Nest", 1));
        _buildings.Add(new BuildingInfo(8, "Market", 1));
        _buildings.Add(new BuildingInfo(9, "Tavern", 1));
    }
}

[System.Serializable]
public class BuildingInfo
{
    public int _ID;
    public string _name;
    public int _level;
    public BuildingInfo(int id,string name, int level)
    {
        _ID = id;
        _name = name;
        _level = level;
    }
}