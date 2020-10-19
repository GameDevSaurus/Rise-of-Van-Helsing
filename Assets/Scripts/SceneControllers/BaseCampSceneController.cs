using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCampSceneController : MonoBehaviour
{
    [SerializeField]
    GameObject[] _buildings;


    [SerializeField]
    GameObject[] _addBuilding;
    void Start()
    {
        for(int i = 1;i< _buildings.Length; i++)
        {
            
            if (SavedDataController.GetBuildingLevel(i) > 0)
            {
                _addBuilding[i].SetActive(false);
                _buildings[i].SetActive(true);
            }
            else
            {
                _addBuilding[i].SetActive(true);
            }
        }
    }
    
    void Update()
    {
        
    }
}
