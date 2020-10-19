using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _cryptModel;
    [SerializeField]
    GameObject _lockBuilding;
    int _state;
    public void BuildCrypt()
    {
        SavedDataController.SetBuildingLevel(6, 1);
    }
    private void Update()
    {
        CheckState();
    }
    public void CheckState()
    {
        _cryptModel.SetActive(false);
        _addBuilding.SetActive(false);
        _lockBuilding.SetActive(false);


        if (SavedDataController.GetBuildingLevel(6) > 0)
        {
            _cryptModel.SetActive(true);
            _state = 2;
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(5) > 0)
            {
                _addBuilding.SetActive(true);
                _state = 1;
            }
            else
            {
                _lockBuilding.SetActive(true);
                _state = 0;
            }
        }
    }
    void Start()
    {

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
}
