using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamelevelIntializer : MonoBehaviour
{

    EnemyController[] _enemies;
    private void Awake()
    {
        GameObject levelsHolder =  GameObject.Find("LevelZones");
        int currentLevel = PlayerPrefs.GetInt("GameLevel");
        LevelDataController.LevelData currentLevelData = LevelDataController.GetLevelData(currentLevel);
        for (int i = 0; i < levelsHolder.transform.childCount; i++)
        {
            levelsHolder.transform.GetChild(i).gameObject.SetActive(false);
        }
        levelsHolder.transform.GetChild(currentLevel).gameObject.SetActive(true);
        GameObject currentLevelHolder = levelsHolder.transform.GetChild(currentLevel).gameObject;
        PlayableLevel currentPlayableLevel = currentLevelHolder.GetComponent<PlayableLevel>();
        currentPlayableLevel.Initialize();
        LineRendererPool lineRendererPool = FindObjectOfType<LineRendererPool>();
        
        PlayerController playerController = FindObjectOfType<PlayerController>();
        playerController.SetPlayerPath(currentLevelHolder.transform.GetChild(1).GetComponent<BezierSpline>());
        playerController.Orient();
        Weapon currentWeapon =  Instantiate(Resources.Load<GameObject>("Prefabs/Weapons/" + currentLevelData._primaryWeaponCategory.ToString()), playerController.GetWeaponPivot()).GetComponent<Weapon>();
        currentWeapon.SetLineRendererPool(lineRendererPool);
        WeaponProjectilesRetriever weaponProjectilesRetriever = FindObjectOfType<WeaponProjectilesRetriever>();
        weaponProjectilesRetriever.SetWeapon(currentWeapon);
        playerController.SetWeapon(currentWeapon);
        playerController.gameObject.SetActive(false);
        InGameController _inGameController = FindObjectOfType<InGameController>();
        FindObjectOfType<HPBarBehaviour>().SetPlayerController(playerController);
        _inGameController._player = playerController.gameObject;
        FindObjectOfType<ShootButtonBehaviour>().SetPlayer(playerController);
        currentPlayableLevel.SetPlayerController(playerController);
        //Añado la recarga al botón de recarga
        GameObject.Find("ReloadButton").GetComponent<Button>().onClick.AddListener(()=>playerController.Reload());
        currentWeapon.SetVfxBloodPool(GameObject.Find("VFXBloodPool").GetComponent<VFXPool>());
        //Asigno valores a la camara
        BezierSpline cameraPath = currentLevelHolder.transform.GetChild(2).GetComponent<BezierSpline>();
        CinematicCameraController cinematicCameraController = FindObjectOfType<CinematicCameraController>();
        cinematicCameraController.SetPath(cameraPath);

        //Creo los enemigos
        EnemySpawner[] enemySpawners = currentLevelHolder.GetComponentsInChildren<EnemySpawner>();
        foreach(EnemySpawner e in enemySpawners)
        {
            EnemyController enemyController = null;
            GameObject instantiatedEnemy = null;
            switch (e.GetEnemyType())
            {
                case EnemyType.Zombie:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_Zombie"), e.transform.position,Quaternion.identity) ;
                    break;

                case EnemyType.WalkingNightmare:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_WalkingNightmare"), e.transform.position, Quaternion.identity);
                    break;

                case EnemyType.CrawlingNightmare:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_CrawlingNightmare"), e.transform.position, Quaternion.identity);
                    break;
                case EnemyType.Troll:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_Troll"), e.transform.position, Quaternion.identity);
                    break;
                case EnemyType.Explosive:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_Explosive"), e.transform.position, Quaternion.identity);
                    break;
                case EnemyType.Spitter:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_Spitter"), e.transform.position, Quaternion.identity);
                    break;
                case EnemyType.Bat:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_Bat"), e.transform.position, Quaternion.identity);
                    break;
                case EnemyType.SkeletonZombie:
                    instantiatedEnemy = Instantiate(Resources.Load<GameObject>("Prefabs/Enemies/Enemy_SkeletonZombie"), e.transform.position, Quaternion.identity);
                    break;
            }
            enemyController = instantiatedEnemy.GetComponent<EnemyController>();
            enemyController.SetPath(e.GetComponent<BezierSpline>());
            enemyController.SetMaxHp(e._maxHP);
            enemyController.SetCurrentHP(e._maxHP);
            enemyController.SetDamage(e._damage);
            enemyController.SetChaseIndex(e._chaseIndex);
            enemyController.SetChaseSpeed(e._speed* (1 + e.animationSpeedOffset));
            enemyController.SetChaseAnimationSpeedOffset(1 + e.animationSpeedOffset);
            enemyController.SetSkin(e._skin);
            enemyController.Orient();
            enemyController.SetPlayerController(playerController);
            if (!e._preInstantiate)
            {
                instantiatedEnemy.SetActive(false);
            }
            currentPlayableLevel._enemyControllers.Add(enemyController);

        }
    }
}
