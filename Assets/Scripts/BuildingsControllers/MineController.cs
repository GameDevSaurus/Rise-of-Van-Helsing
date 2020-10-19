using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _lockedBuilding;
    [SerializeField]
    GameObject _mineModel;
    int _state;
    public void BuildMine()
    {
        SavedDataController.SetBuildingLevel(3, 1);
    }
    void Start()
    {

    }
    public void CheckState()
    {
        _mineModel.SetActive(false);
        _addBuilding.SetActive(false);
        _lockedBuilding.SetActive(false);

        if (SavedDataController.GetBuildingLevel(3) > 0)
        {
            _mineModel.SetActive(true);
            _state = 2;
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(0) > 1)
            {
                _addBuilding.SetActive(true);
                _state = 1;
            }
            else
            {
                _lockedBuilding.SetActive(true);
                _state = 0;
            }
        }
    }
    private void Update()
    {
        CheckState();
    }
    public void OnMouseDown()
    {
        switch (_state)
        {
            case 0:
                break;

            case 1:
                FindObjectOfType<BuildingsPanelConstructionController>().ShowCanvas();
                break;

            case 2:
                break;
        }
    }
}
