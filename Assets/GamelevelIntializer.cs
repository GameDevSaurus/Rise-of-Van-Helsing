using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamelevelIntializer : MonoBehaviour
{
    private void Awake()
    {
        GameObject currentLevelHolder =  GameObject.Find("LevelZones");

        int currentLevel = PlayerPrefs.GetInt("GameLevel");
        for(int i = 0; i< currentLevelHolder.transform.childCount; i++)
        {
            currentLevelHolder.transform.GetChild(i).gameObject.SetActive(false);
        }
        currentLevelHolder.transform.GetChild(currentLevel).gameObject.SetActive(true);
        BezierSpline cameraPath = currentLevelHolder.transform.GetChild(currentLevel).GetChild(1).GetComponent<BezierSpline>();
        CinematicCameraController cinematicCameraController = FindObjectOfType<CinematicCameraController>();
        cinematicCameraController.SetPath(cameraPath);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
