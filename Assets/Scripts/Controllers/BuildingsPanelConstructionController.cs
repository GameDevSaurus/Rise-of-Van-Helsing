using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingsPanelConstructionController : MonoBehaviour
{
    [SerializeField]
    GameObject _buildingCanvas;

    //Shrine
    ShrineController _shrineController;
    [SerializeField]
    GameObject _shrineButton;
    [SerializeField]
    GameObject _shrineHolder;

    //Warehouse
    WarehouseController _warehouseController;
    [SerializeField]
    GameObject _warehouseButton;
    [SerializeField]
    GameObject _warehouseHolder;
    [SerializeField]
    GameObject _warehouseRequeriment;

    //Mine
    MineController _mineController;
    [SerializeField]
    GameObject _mineButton;
    [SerializeField]
    GameObject _mineHolder;
    [SerializeField]
    GameObject _mineRequeriment;

    //Forge
    ForgeController _forgeController;
    [SerializeField]
    GameObject _forgeButton;
    [SerializeField]
    GameObject _forgeHolder;
    [SerializeField]
    GameObject _forgeRequeriment;

    //Graveyard
    GraveyardController _graveyardController;
    [SerializeField]
    GameObject _graveyardButton;
    [SerializeField]
    GameObject _graveyardHolder;
    [SerializeField]
    GameObject _graveyardRequeriment;

    //Crypt
    CryptController _cryptController;
    [SerializeField]
    GameObject _cryptButton;
    [SerializeField]
    GameObject _cryptHolder;
    [SerializeField]
    GameObject _cryptRequeriment;
    [SerializeField]
    GameObject _leftPanel;
    [SerializeField]
    GameObject _rightPanel;
    void Start()
    {
        _shrineController = FindObjectOfType<ShrineController>();
        _warehouseController = FindObjectOfType<WarehouseController>();
        _mineController = FindObjectOfType<MineController>();
        _forgeController = FindObjectOfType<ForgeController>();
        _graveyardController = FindObjectOfType<GraveyardController>();
        _cryptController = FindObjectOfType<CryptController>();
    }
    public void BuildCrypt()
    {
        _cryptController.BuildCrypt();
        _buildingCanvas.SetActive(false);
    }
    public void BuildGraveyard()
    {
        _graveyardController.BuildGraveyard();
        _buildingCanvas.SetActive(false);
    }

    public void BuildShrine()
    {
        _shrineController.BuildShrine();
        _buildingCanvas.SetActive(false);
    }
    public void BuildWarehouse()
    {
        _warehouseController.BuildWarehouse();
        _buildingCanvas.SetActive(false);
    }
    public void BuildMine()
    {
        _mineController.BuildMine();
        _buildingCanvas.SetActive(false);

    }
    public void BuildForge()
    {
        _forgeController.BuildForge();
        _buildingCanvas.SetActive(false);
    }
    public void ShowCanvas()
    {
        _leftPanel.SetActive(false);
        _rightPanel.SetActive(false);
        if (SavedDataController.GetBuildingLevel(1) > 0)
        {
            _shrineHolder.SetActive(false);
        }
        if (SavedDataController.GetBuildingLevel(2) > 0)
        {
            _warehouseHolder.SetActive(false);
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(1) > 0)
            {
                _warehouseButton.SetActive(true);
                _warehouseRequeriment.SetActive(false);
            }
            else
            {
                _warehouseButton.SetActive(false);
                _warehouseRequeriment.SetActive(true);
            }
        }

        if (SavedDataController.GetBuildingLevel(3) > 0)
        {
            _mineHolder.SetActive(false);
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(0) > 1)
            {
                _mineButton.SetActive(true);
                _mineRequeriment.SetActive(false);
            }
            else
            {
                _mineButton.SetActive(false);
                _mineRequeriment.SetActive(true);
            }
        }

        if(SavedDataController.GetBuildingLevel(4) > 0)
        {
            _forgeHolder.SetActive(false);
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(3) > 0)
            {
                _forgeButton.SetActive(true);
                _forgeRequeriment.SetActive(false);
            }
            else
            {
                _forgeButton.SetActive(false);
                _forgeRequeriment.SetActive(true);
            }
        }

        if (SavedDataController.GetBuildingLevel(5) > 0)
        {
            _graveyardHolder.SetActive(false);
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(0) > 2)
            {
                _graveyardButton.SetActive(true);
                _graveyardRequeriment.SetActive(false);
            }
            else
            {
                _graveyardButton.SetActive(false);
                _graveyardRequeriment.SetActive(true);
            }
        }

        if (SavedDataController.GetBuildingLevel(6) > 0)
        {
            _cryptHolder.SetActive(true);
        }
        else
        {
            if (SavedDataController.GetBuildingLevel(5) > 0)
            {
                _cryptButton.SetActive(true);
                _cryptRequeriment.SetActive(false);
            }
            else
            {
                _cryptButton.SetActive(false);
                _cryptRequeriment.SetActive(true);
            }
        }

        _buildingCanvas.SetActive(true);
    }
    public void HideCanvas()
    {
        _leftPanel.SetActive(true);
        _rightPanel.SetActive(true);
        _buildingCanvas.SetActive(false);
    }
    void Update()
    {
        
    }
}
