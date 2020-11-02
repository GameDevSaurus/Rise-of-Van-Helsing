using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSceneController : MonoBehaviour
{
    public void SelectLevel(int level)
    {
        PlayerPrefs.SetInt("GameLevel", level);
        GameEvents.LoadScene.Invoke("Area0");
    }
}
