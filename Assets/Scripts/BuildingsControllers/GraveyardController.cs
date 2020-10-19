using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _graveyardModel;
    [SerializeField]
    GameObject _lockBuilding;
    int _state;
    public void BuildGraveyard()
    {
        SavedDataController.SetBuildingLevel(5, 1);
    }
    void Start()
    {

    }
    private void Update()
    {
        CheckState();
    }
    void CheckState()
    {
        _graveyardModel.SetActive(false);
        _addBuilding.SetActive(false);
        _lockBuilding.SetActive(false);

        if (SavedDataController.GetBuildingLevel(5) > 0)
        {
            _graveyardModel.SetActive(true);
            _state = 2;
        }
        else
        {

            if (SavedDataController.GetBuildingLevel(0) > 2)
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
