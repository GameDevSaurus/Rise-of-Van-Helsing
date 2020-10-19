using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrineController : MonoBehaviour
{
    [SerializeField]
    GameObject _addBuilding;
    [SerializeField]
    GameObject _shrineModel;
    int _state;
    void Start()
    {
        CheckState();
    }
    
    public int GetState()
    {
        return _state;
    }
    public void BuildShrine()
    {
        SavedDataController.SetBuildingLevel(1, 1);
    }
    public void CheckState()
    {
        _shrineModel.SetActive(false);
        _addBuilding.SetActive(false);

        if (SavedDataController.GetBuildingLevel(1) > 0)
        {
            _shrineModel.SetActive(true);
            _state = 1;
        }
        else
        {
            _addBuilding.SetActive(true);
            _state = 0;
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
                FindObjectOfType<BuildingsPanelConstructionController>().ShowCanvas();
                break;

            case 1:
                print("Altarsito funsionoo");
                break;
        }
    }
}
