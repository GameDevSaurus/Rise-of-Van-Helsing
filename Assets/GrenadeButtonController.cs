using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeButtonController : MonoBehaviour
{

    void Start()
    {
        int currentLevel = PlayerPrefs.GetInt("GameLevel");

        if(currentLevel > 5)
        {
            gameObject.SetActive(true);

        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
