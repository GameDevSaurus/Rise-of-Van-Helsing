using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InGameController : MonoBehaviour
{
    int _currentGameLevel;
    [SerializeField]
    TextMeshProUGUI _levelIndicator;
    private void Start()
    {
        _currentGameLevel = PlayerPrefs.GetInt("GameLevel");

        _levelIndicator.text = "JUGANDO EL NIVEL " + _currentGameLevel;
    }
    public void PassLevel()
    {
        SavedDataController.SetLevelProgression(_currentGameLevel, true);
        switch (_currentGameLevel)
        {
            case 0:
                GameEvents.ShowDialog.Invoke(0);
                PlayerPrefs.SetString("SceneToLoad", "Area0");
                PlayerPrefs.SetInt("GameLevel", 1);
                PlayerPrefs.SetString("SceneFromLoad", "Lore");
                GameEvents.LoadScene.Invoke("Loading");
                break;
            case 1:
                PlayerPrefs.SetInt("LoreCinematic", 1);
                GameEvents.LoadScene.Invoke("Lore");
                break;
        }
        
        
    }
}
