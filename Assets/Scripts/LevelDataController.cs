using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataController : MonoBehaviour
{
    static List<LevelData> _levelsData;
    static bool _initialized;
    public static void Init()
    {
        _levelsData = new List<LevelData>();
        _levelsData.Add(new LevelData(0, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(1, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(2, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(3, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(4, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(5, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(6, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(7, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(8, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(9, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(10, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(11, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(12, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(13, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(14, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(15, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(16, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(17, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(18, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(19, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(20, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(21, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(22, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(23, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(24, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(25, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(26, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(27, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(28, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(29, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(30, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(31, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(32, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(33, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(34, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(35, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(36, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(37, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(38, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
        _levelsData.Add(new LevelData(39, "Nivel tutorial movimiento y cuchillo", WeaponCategory.HandCrossbow, WeaponCategory.AutoCrossbow));
    }
    
    public static LevelData GetLevelData(int level)
    {
        if (!_initialized)
        {
            Init();
        }

        return _levelsData[level];
    }

    public class LevelData
    {
        public int _IDLevel;
        public string _description;
        public WeaponCategory _primaryWeaponCategory;
        public WeaponCategory _secondaryWeaponCategory;
        public LevelData(int IDLevel, string description, WeaponCategory primaryWeaponCategory, WeaponCategory secondaryWeaponCategory)
        {
            _IDLevel = IDLevel;
            _description = description;
            _primaryWeaponCategory = primaryWeaponCategory;
            _secondaryWeaponCategory = secondaryWeaponCategory;
        }
    }
}
