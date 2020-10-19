using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationSceneController : MonoBehaviour
{
    
    void Start()
    {
        if (!SavedDataController.IsInitialized())
        {
            //Si es la primera vez que juega, no tendrá perfil creado, con lo que lo creamos y cargamos el nivel 1 pero para ello esperamos al tiempo
            SavedDataController.Initialize();
            StartCoroutine(WaitforLoadLore(0));
        }
        else
        {
            //Si tiene perfil, es posible que no llegara a completar el nivel 1, con lo que lo primero que hacemos es cargar el perfil en el jugador, y comprobar el progreso de nivel 1. Si dicho progreso es 0, lo mandamos ver el lore y al nivel 0, si no lo mandamos al home.
            SavedDataController.LoadAll();
            if (SavedDataController.GetLevelProgression(0))
            {
                StartCoroutine(WaitForLoadHome());
            }
            else
            {
                StartCoroutine(WaitforLoadLore(0));
            }
        }
     
    }

    IEnumerator WaitForLoadHome()
    {
        yield return new WaitForSeconds(3f);
        GameEvents.LoadScene.Invoke("BaseCamp");
    }

    IEnumerator WaitforLoadLore(int gameLevel)
    {
        yield return new WaitForSeconds(3f);
        PlayerPrefs.SetInt("LoreCinematic", gameLevel);
        GameEvents.LoadScene.Invoke("Lore");
    }

}
