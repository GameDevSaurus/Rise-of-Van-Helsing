using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _lockedBuilding;
    [SerializeField]
    GameObject _warehouse;

    int _state;
    void Start()
    {
    }
    public void BuildWarehouse()
    {
        SavedDataController.SetBuildingLevel(2, 1);
    }
    public void CheckState()
    {
        _addBuilding.SetActive(false);
        _warehouse.SetActive(false);
        _lockedBuilding.SetActive(false);

        if (SavedDataController.GetBuildingLevel(2) > 0)
        {
            _warehouse.SetActive(true);
            _state = 2;
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(1) > 0)
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
                print("Almasén Lockeaooo");
                break;

            case 1:
                FindObjectOfType<BuildingsPanelConstructionController>().ShowCanvas();
                break;

            case 2:
                print("Almasén funsiono");
                break;
        }
    }
}
