using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class DataMnagement : MonoBehaviour
{

    const string _userDataFileName = "UserData.json";
    const string _economyDataFileName = "EconomyData.json";
    const string _levelsProgressionFileName = "LevelsProgressionData.json";
    const string _baseCampDataFileName = "BaseCampData.json";
    const string _buildingsDataFileName = "BuildingsData.json";

    [MenuItem("DataManagement/Open PersistentDataPath Folder")]
    public static void OpenPersistentDataPath()
    {
        EditorUtility.RevealInFinder(Application.persistentDataPath);
    }

    [MenuItem("DataManagement/Delete PersistentDataPath Data")]
    [SerializeField]
    public static void DeleteStreamingAssetsFolder()
    {
        File.Delete(Application.persistentDataPath + "/"+_userDataFileName);
        File.Delete(Application.persistentDataPath + "/" + _economyDataFileName);
        File.Delete(Application.persistentDataPath + "/" + _levelsProgressionFileName);
        File.Delete(Application.persistentDataPath + "/" + _baseCampDataFileName);
        File.Delete(Application.persistentDataPath + "/" + _buildingsDataFileName);
    }

    [MenuItem("DataManagement/DeletePlayerPrefs")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

}
