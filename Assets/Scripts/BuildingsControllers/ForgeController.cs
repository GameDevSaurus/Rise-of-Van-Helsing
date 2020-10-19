using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _forgeModel;
    [SerializeField]
    GameObject _lockForge;
    int _state;
    void Start()
    {


    }
    public void BuildForge()
    {
        SavedDataController.SetBuildingLevel(4, 1);
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
                print("Forja Lockeaooo");
                break;

            case 1:
                FindObjectOfType<BuildingsPanelConstructionController>().ShowCanvas();
                break;

            case 2:
                print("Forja funsiono");
                break;
        }
    }
    void CheckState()
    {
        _forgeModel.SetActive(false);
        _addBuilding.SetActive(false);
        _lockForge.SetActive(false);

        if (SavedDataController.GetBuildingLevel(4) > 0)
        {
            _forgeModel.SetActive(true);
            _state = 2;
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(3) > 0)
            {
                _addBuilding.SetActive(true);
                _state = 1;
            }
            else
            {
                _lockForge.SetActive(true);
                _state = 0;
            }
        }
    }
}
