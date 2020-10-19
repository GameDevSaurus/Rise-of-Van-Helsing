using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneShortcuts : MonoBehaviour
{
    [MenuItem("Zones/0-9/0")]
    public static void SetZoneToZero()
    {
        SetZone(0);
    }
    [MenuItem("Zones/0-9/1")]
    public static void SetZoneToOne()
    {
        SetZone(1);
    }
    [MenuItem("Zones/0-9/2")]
    public static void SetZoneToTwo()
    {
        SetZone(2);
    }
    [MenuItem("Zones/0-9/3")]
    public static void SetZoneToThree()
    {
        SetZone(3);
    }
    [MenuItem("Zones/0-9/4")]
    public static void SetZoneToFour()
    {
        SetZone(4);
    }
    [MenuItem("Zones/0-9/5")]
    public static void SetZoneToFive()
    {
        SetZone(5);
    }
    [MenuItem("Zones/0-9/6")]
    public static void SetZoneToSix()
    {
        SetZone(6);
    }
    [MenuItem("Zones/0-9/7")]
    public static void SetZoneToSeven()
    {
        SetZone(7);
    }
    [MenuItem("Zones/0-9/8")]
    public static void SetZoneToEight()
    {
        SetZone(8);
    }
    [MenuItem("Zones/0-9/9")]
    public static void SetZoneToNine()
    {
        SetZone(9);
    }
    [MenuItem("Zones/10-19/10")]
    public static void SetZoneTo10()
    {
        SetZone(10);
    }
    [MenuItem("Zones/10-19/11")]
    public static void SetZoneTo11()
    {
        SetZone(11);
    }
    [MenuItem("Zones/10-19/12")]
    public static void SetZoneTo12()
    {
        SetZone(12);
    }
    [MenuItem("Zones/10-19/13")]
    public static void SetZoneTo13()
    {
        SetZone(13);
    }
    [MenuItem("Zones/10-19/14")]
    public static void SetZoneTo14()
    {
        SetZone(14);
    }
    [MenuItem("Zones/10-19/15")]
    public static void SetZoneTo15()
    {
        SetZone(15);
    }
    [MenuItem("Zones/10-19/16")]
    public static void SetZoneTo16()
    {
        SetZone(16);
    }
    [MenuItem("Zones/10-19/17")]
    public static void SetZoneTo17()
    {
        SetZone(17);
    }
    [MenuItem("Zones/10-19/18")]
    public static void SetZoneTo18()
    {
        SetZone(18);
    }
    [MenuItem("Zones/10-19/19")]
    public static void SetZoneTo19()
    {
        SetZone(19);
    }
    [MenuItem("Zones/20-29/20")]
    public static void SetZoneTo20()
    {
        SetZone(20);
    }
    [MenuItem("Zones/20-29/21")]
    public static void SetZoneTo21()
    {
        SetZone(21);
    }
    [MenuItem("Zones/20-29/22")]
    public static void SetZoneTo22()
    {
        SetZone(22);
    }
    [MenuItem("Zones/20-29/23")]
    public static void SetZoneTo23()
    {
        SetZone(23);
    }
    [MenuItem("Zones/20-29/24")]
    public static void SetZoneTo24()
    {
        SetZone(24);
    }
    [MenuItem("Zones/20-29/25")]
    public static void SetZoneTo25()
    {
        SetZone(25);
    }
    [MenuItem("Zones/20-29/26")]
    public static void SetZoneTo26()
    {
        SetZone(26);
    }
    [MenuItem("Zones/20-29/27")]
    public static void SetZoneTo27()
    {
        SetZone(27);
    }
    [MenuItem("Zones/20-29/28")]
    public static void SetZoneTo28()
    {
        SetZone(28);
    }
    [MenuItem("Zones/20-29/29")]
    public static void SetZoneTo29()
    {
        SetZone(29);
    }
    [MenuItem("Zones/30-39/30")]
    public static void SetZoneTo30()
    {
        SetZone(30);
    }
    [MenuItem("Zones/30-39/31")]
    public static void SetZoneTo31()
    {
        SetZone(31);
    }
    [MenuItem("Zones/30-39/32")]
    public static void SetZoneTo32()
    {
        SetZone(32);
    }
    [MenuItem("Zones/30-39/33")]
    public static void SetZoneTo33()
    {
        SetZone(33);
    }
    [MenuItem("Zones/30-39/34")]
    public static void SetZoneTo34()
    {
        SetZone(34);
    }
    [MenuItem("Zones/30-39/35")]
    public static void SetZoneTo35()
    {
        SetZone(35);
    }
    [MenuItem("Zones/30-39/36")]
    public static void SetZoneTo36()
    {
        SetZone(36);
    }
    [MenuItem("Zones/30-39/37")]
    public static void SetZoneTo37()
    {
        SetZone(37);
    }
    [MenuItem("Zones/30-39/38")]
    public static void SetZoneTo38()
    {
        SetZone(38);
    }
    [MenuItem("Zones/30-39/39")]
    public static void SetZoneTo39()
    {
        SetZone(39);
    }

    [MenuItem("Scenes/Configuration")]
    public static void OpenConfiguration()
    {
        LoadScene("Configuration");
    }

    [MenuItem("Scenes/Lore")]
    public static void OpenLore()
    {
        LoadScene("Lore");
    }

    [MenuItem("Scenes/BaseCamp")]
    public static void OpenBaseCamp()
    {
        LoadScene("BaseCamp");
    }

    [MenuItem("Scenes/Loading")]
    public static void OpenLoading()
    {
        LoadScene("Loading");
    }
    [MenuItem("Scenes/Areas/Area0")]
    public static void OpenArea0()
    {
        LoadArea("Area0");
    }


    public static void LoadScene(string name)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) //Si el usuario quiere guardar la escena, guardar
        {
            EditorSceneManager.OpenScene("Assets/Scenes/" + name + ".unity");
        }
    }
    public static void LoadArea(string area)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) //Si el usuario quiere guardar la escena, guardar
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Areas/" + area + ".unity");
        }
    }
    public static void SetZone(int zone)
    {
        GameObject levelZonesGO = GameObject.Find("LevelZones");
        if (zone < levelZonesGO.transform.childCount)
        {
            PlayerPrefs.SetInt("Zone2Load", zone);
            for (int i = 0; i < levelZonesGO.transform.childCount; i++)
            {
                levelZonesGO.transform.GetChild(i).gameObject.SetActive(false);
            }
            levelZonesGO.transform.GetChild(zone).gameObject.SetActive(true);
        }
    }
}
