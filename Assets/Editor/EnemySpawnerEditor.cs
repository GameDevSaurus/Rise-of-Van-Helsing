using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EnemySpawner))]
public class EnemySpawnerEditor : Editor
{
    float[] zombieSpeeds = { 0.85f, 1.3f, 0.85f, 1.2f, 5f, 6f, 7f, 6.75f };
    float[] crawlingNightmareSpeeds = { 1f };
    float[] walkingNightmareSpeeds = { 5f };
    float[] trollSpeeds = {3f};
    float[] werewolfSpeeds = { 2f };
    float[] explosiveSpeeds = { 1.75f };
    float[] spitterSpeeds = {100f };
    float[] batSpeeds = { 4f };
    float[] vampireGirlSpeeds = { 4f };
    float[] hulkSpeeds = { 2 };

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EnemySpawner myEnemySpawner = (EnemySpawner)target;
        

        string[] enemyTypes = new string[]
        {
            "Crawling Nightmare",
            "Walking Nightmare",
            "Zombie",
            "Skeleton Zombie",
            "Troll",
            "Werewolf",
            "Explosive",
            "Spitter",
            "Bat",
            "VampireGirl",
            "Hulk"

        };
        string[] zombieChases = new string[]
        {
            "Slow 0",
            "Slow 1",
            "Slow 2",
            "Slow 3",
            "Fast 0",
            "Fast 1",
            "Fast 2",
            "Fast 3"
        };
        string[] zombieSkins = new string[]
        {
            "Normal",
            "Herido",
            "Verde",
            "Rojo"
        };

        string[] skeletonZombieSkins = new string[]
        {
            "V0",
            "V1",
            "V2",
            "V3"
        };
        myEnemySpawner._enemy = (EnemyType)EditorGUILayout.Popup("Enemy Type", (int)myEnemySpawner._enemy, enemyTypes);
        myEnemySpawner._maxHP = EditorGUILayout.IntField("HP", myEnemySpawner._maxHP);
        myEnemySpawner._damage = EditorGUILayout.IntField("Damage", myEnemySpawner._damage);
        


        myEnemySpawner.animationSpeedOffset =  EditorGUILayout.Slider("Chase Speed Offset", myEnemySpawner.animationSpeedOffset, -0.25f, 0.25f);
        myEnemySpawner._preInstantiate = EditorGUILayout.Toggle("PreInstantiate", myEnemySpawner._preInstantiate);
        myEnemySpawner._startTaunting = EditorGUILayout.Toggle("Start Taunting", myEnemySpawner._startTaunting);
        float finalSpeed = myEnemySpawner._speed * (1 + myEnemySpawner.animationSpeedOffset);
        myEnemySpawner._onlyIdle = EditorGUILayout.Toggle("Only Idle", myEnemySpawner._onlyIdle);
        myEnemySpawner._useRaycast = EditorGUILayout.Toggle("Use Raycast", myEnemySpawner._useRaycast);
        EditorGUILayout.LabelField("Speed", finalSpeed.ToString());
        switch (myEnemySpawner._enemy)
        {
            case EnemyType.CrawlingNightmare:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = crawlingNightmareSpeeds[0];
                break;
            case EnemyType.WalkingNightmare:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = walkingNightmareSpeeds[0];
                break;
            case EnemyType.Zombie:
                myEnemySpawner._chaseIndex = EditorGUILayout.Popup("Chase Index", (int)myEnemySpawner._chaseIndex, zombieChases);
                myEnemySpawner._speed = zombieSpeeds[myEnemySpawner._chaseIndex];
                myEnemySpawner._skin = EditorGUILayout.Popup("Skin", (int)myEnemySpawner._skin, zombieSkins);
                break;
            case EnemyType.SkeletonZombie:
                myEnemySpawner._chaseIndex = EditorGUILayout.Popup("Chase Index", (int)myEnemySpawner._chaseIndex, zombieChases);
                myEnemySpawner._speed = zombieSpeeds[myEnemySpawner._chaseIndex];
                myEnemySpawner._skin = EditorGUILayout.Popup("Skin", (int)myEnemySpawner._skin, skeletonZombieSkins);
                break;
            case EnemyType.Troll:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = trollSpeeds[0];
                EditorGUILayout.LabelField("Skin", myEnemySpawner._skin.ToString());

                break;
            case EnemyType.Werewolf:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = werewolfSpeeds[0];
                break;
            case EnemyType.Explosive:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = explosiveSpeeds[0];
                break;
            case EnemyType.Spitter:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = spitterSpeeds[0];
                break;
            case EnemyType.Bat:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = batSpeeds[0];
                break;
            case EnemyType.VampireGirl:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = vampireGirlSpeeds[0];
                break;
            case EnemyType.Hulk:
                myEnemySpawner._skin = 0;
                myEnemySpawner._speed = hulkSpeeds[0];
                break;
        }

    }
}
