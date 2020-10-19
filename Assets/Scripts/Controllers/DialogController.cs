using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    List<string> _dialogsToPlay;
    [SerializeField]
    GameObject _fullCanvasHolder;

    private void Awake()
    {
        GameEvents.ShowDialog.AddListener(ShowDialog);
    }
    private void Start()
    {
        _dialogsToPlay = new List<string>();
        _dialogsToPlay.Add("D0");
        _dialogsToPlay.Add("D1");
        _dialogsToPlay.Add("D2");
    }

    void ShowDialog(int dialog)
    {
        _fullCanvasHolder.SetActive(true);
    }
    public void Continue()
    {
        GameEvents.LoadScene.Invoke("Lore");
    }
    
   
}
