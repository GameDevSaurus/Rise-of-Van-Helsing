using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoadingSceneController : MonoBehaviour
{
    [SerializeField]
    GameObject _comingFromLoreLoading;
    [SerializeField]
    GameObject _standardLoading;

    void Start()
    {
        string _sceneFrom = PlayerPrefs.GetString("SceneFromLoad");
        string _sceneTo = PlayerPrefs.GetString("SceneToLoad");

        if(_sceneFrom == "Lore")
        {
            _comingFromLoreLoading.SetActive(true);
        }
        else
        {
            _standardLoading.SetActive(true);
        }
        StartCoroutine(WaitAndLoadLevel());
    }

    IEnumerator WaitAndLoadLevel()
    {
        yield return new WaitForSeconds(1f);
        GameEvents.LoadSceneAsync.Invoke(PlayerPrefs.GetString("SceneToLoad"));
    }

    void Update()
    {
        
    }
}
