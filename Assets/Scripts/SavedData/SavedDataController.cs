using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SavedDataController : MonoBehaviour
{
    static UserData _userData;
    static EconomyData _economyData;
    static LevelsProgressionData _levelsProgressionData;
    static BuildingsData _buildingsData;

    const string _userDataFileName = "UserData.json";
    const string _economyDataFileName = "EconomyData.json";
    const string _levelsProgressionFileName = "LevelsProgressionData.json";
    const string _buildingsDataFileName = "BuildingsData.json";

    static bool isLoaded;

    public static bool IsInitialized()
    {
        bool hasPlayerData = File.Exists(Application.persistentDataPath+"/" + _userDataFileName);
        bool hasEconomyData = File.Exists(Application.persistentDataPath + "/" + _economyDataFileName);
        bool hasLevelsProgressionData = File.Exists(Application.persistentDataPath + "/" + _levelsProgressionFileName);
        bool hasBuildingsData = File.Exists(Application.persistentDataPath + "/" + _buildingsDataFileName);
        bool hasEverything = hasPlayerData && hasEconomyData && hasLevelsProgressionData  && hasBuildingsData;
        return hasEverything;
    }

    public static void Initialize()
    {
        _userData = new UserData();
        _economyData = new EconomyData();
        _levelsProgressionData = new LevelsProgressionData();
        _buildingsData = new BuildingsData();
        SaveAll();
    }
    public static int GetCompletedBaseAssaults()
    {
        return _levelsProgressionData._baseAssaults;
    }
    public static void SetLevelProgression(int level, bool completed)
    {
        _levelsProgressionData._levelsProgressionData[level] = completed;
        SaveLevelsProgression();
    }
    public static bool GetLevelProgression(int level)
    {
        return _levelsProgressionData._levelsProgressionData[level];
    }

    static void SaveLevelsProgression()
    {
        File.WriteAllText(Application.persistentDataPath + "/" + _levelsProgressionFileName, JsonUtility.ToJson(_levelsProgressionData));
    }
    static void SaveUserData()
    {
        File.WriteAllText(Application.persistentDataPath + "/" + _userDataFileName, JsonUtility.ToJson(_userData));
    }
    static void SaveEconomyData()
    {
        File.WriteAllText(Application.persistentDataPath + "/" + _economyDataFileName, JsonUtility.ToJson(_economyData));
    }

    static void SaveBuildingsData()
    {
        File.WriteAllText(Application.persistentDataPath + "/" + _buildingsDataFileName, JsonUtility.ToJson(_buildingsData));
    }
    static void SaveAll()
    {
        SaveUserData();
        SaveEconomyData();
        SaveLevelsProgression();
        SaveBuildingsData();
    }
    public static void Precheck()
    {
        if (!IsInitialized())
        {
            Initialize();
        }
        else
        {
            if (!isLoaded)
            {
                LoadAll();
            }
        }
    }
    public static void SetBuildingLevel(int building, int level)
    {
        Precheck();
        _buildingsData._buildings[building]._level = level;
        SaveAll();
    }
    public static int GetBuildingLevel(int building)
    {
        Precheck();
        return _buildingsData._buildings[building]._level;
    }
    public static string GetBuildingName(int building)
    {
        if (!IsInitialized())
        {
            Initialize();
        }
        else
        {
            if (!isLoaded)
            {
                LoadAll();
            }
        }

        return _buildingsData._buildings[building]._name;
    }
    public static void LoadAll()
    {
        _userData = JsonUtility.FromJson<UserData>(File.ReadAllText(Application.persistentDataPath + "/" + _userDataFileName));
        _economyData = JsonUtility.FromJson<EconomyData>(File.ReadAllText(Application.persistentDataPath + "/" + _economyDataFileName));
        _levelsProgressionData = JsonUtility.FromJson<LevelsProgressionData>(File.ReadAllText(Application.persistentDataPath + "/" + _levelsProgressionFileName));
        _buildingsData = JsonUtility.FromJson<BuildingsData>(File.ReadAllText(Application.persistentDataPath + "/" + _buildingsDataFileName));
        isLoaded = true;
    }
}
