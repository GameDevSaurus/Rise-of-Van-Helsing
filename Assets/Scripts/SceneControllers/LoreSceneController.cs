using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LoreSceneController : MonoBehaviour
{
    List<Cinematic> _cinematics;
    [SerializeField]
    TextMeshProUGUI _narrativeText;
    int _currentDialogue;
    int _currentCinematic;
    [SerializeField]
    GameObject _touchForContinue;
    bool _canTouch;
    [SerializeField]
    GameObject[] _sceneTypesObjects;
    TransitionsController _transitionsController;
    [SerializeField]
    List<Image> layersImageOneImage;
    [SerializeField]
    List<Image> layersImageTwoImages;
    [SerializeField]
    Image _twoImagesFadeMask;
    [SerializeField]
    AnimationCurve _animationCurve;
    void Start()
    {
        _cinematics = new List<Cinematic>();
        _transitionsController = FindObjectOfType<TransitionsController>();
        Dialogue d0 = new Dialogue(0, 0, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "ES EL AÑO 1476.", "EL MUNDO QUE CONOCEMOS SE DEBATE EN UNA LUCHA CONSTANTE ENTRE EL BIEN Y EL MAL.", "FORMO PARTE DE UNA ORDEN DE CAZADORES QUE INTENTA DEVOLVER LA OSCURIDAD\nAL INFIERNO AL QUE PERTENECE...", "Y ESTOY DISPUESTO A PERDER LA VIDA PARA CONSEGUIRLO." }, new List<int> { 0, 2 }, new List<Vector2> { new Vector2(66, 17), new Vector2(-1000, -31) }, new List<Vector2> { new Vector2(-66, 17), new Vector2(-300, -31)});
        Dialogue d1 = new Dialogue(1, 1, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "EN UNA DE MIS EXPEDICIONES, ESCUCHO RUIDOS EXTRAÑOS EN UN ANTIGUO PUEBLO...", "UN PUEBLO QUE LLEVA ABANDONADO VARIOS AÑOS.", "ME ACERCARÉ A EXPLORAR CAUTELOSAMENTE, NO QUIERO ARRIESGARME SIN MOTIVO.", "PERO TAMPOCO TENGO MIEDO A LA MUERTE." }, new List<int> { 0, 2 ,3,4,5}, new List<Vector2> { new Vector2(50, 0), new Vector2(440, -16), new Vector2(250, -20), new Vector2(200, -134), new Vector2(-300, 17) }, new List<Vector2> { new Vector2(0, 0), new Vector2(278, -16), new Vector2(150, -20), new Vector2(150, -154), new Vector2(-200, 17) });
        Dialogue d2 = new Dialogue(0, 0, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "¿HE COMENTADO QUE EL MUNDO ESTÁ LLENO DE CRIATURAS SEDIENTAS DE SANGRE?" }, new List<int> { 0, 2 }, new List<Vector2> { new Vector2(66, 17), new Vector2(-1000, -31) }, new List<Vector2> { new Vector2(-66, 17), new Vector2(-300, -31) });

        Cinematic c0 = new Cinematic(new List<Dialogue> {d0,d1, d2});

        Dialogue c1d0 = new Dialogue(0, 0, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "ES EL AÑO 1476.", "EL MUNDO QUE CONOCEMOS SE DEBATE EN UNA LUCHA CONSTANTE ENTRE EL BIEN Y EL MAL.", "FORMO PARTE DE UNA ORDEN DE CAZADORES QUE INTENTA DEVOLVER LA OSCURIDAD\nAL INFIERNO AL QUE PERTENECE...", "Y ESTOY DISPUESTO A PERDER LA VIDA PARA CONSEGUIRLO." }, new List<int> { 0, 2 }, new List<Vector2> { new Vector2(66, 17), new Vector2(-1000, -31) }, new List<Vector2> { new Vector2(-66, 17), new Vector2(-300, -31) });
        Dialogue c1d1 = new Dialogue(1, 1, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "EN UNA DE MIS EXPEDICIONES, ESCUCHO RUIDOS EXTRAÑOS EN UN ANTIGUO PUEBLO...", "UN PUEBLO QUE LLEVA ABANDONADO VARIOS AÑOS.", "ME ACERCARÉ A EXPLORAR CAUTELOSAMENTE, NO QUIERO ARRIESGARME SIN MOTIVO.", "PERO TAMPOCO TENGO MIEDO A LA MUERTE." }, new List<int> { 0, 2, 3, 4, 5 }, new List<Vector2> { new Vector2(50, 0), new Vector2(440, -16), new Vector2(250, -20), new Vector2(200, -134), new Vector2(-300, 17) }, new List<Vector2> { new Vector2(0, 0), new Vector2(278, -16), new Vector2(150, -20), new Vector2(150, -154), new Vector2(-200, 17) });
        Dialogue c1d2 = new Dialogue(0, 0, new List<string> { "imageName0", "NameImage1", "_name_of_image_234" }, new List<string> { "¿HE COMENTADO QUE EL MUNDO ESTÁ LLENO DE CRIATURAS SEDIENTAS DE SANGRE?" }, new List<int> { 0, 2 }, new List<Vector2> { new Vector2(66, 17), new Vector2(-1000, -31) }, new List<Vector2> { new Vector2(-66, 17), new Vector2(-300, -31) });
        Cinematic c1 = new Cinematic(new List<Dialogue> { c1d0, c1d1, c1d2 });

        _cinematics.Add(c1);
        _currentCinematic = PlayerPrefs.GetInt("LoreCinematic");
        _canTouch = false;
        _touchForContinue.SetActive(false);
        ShowDialogue();
    }

    void Continue()
    {
        if(_currentDialogue < _cinematics[_currentCinematic]._dialogues.Count-1)
        {
            print(_cinematics[_currentCinematic]._dialogues.Count);
            StartCoroutine(CRContinue());
        }
        else
        {
            switch (_currentCinematic)
            {
                case 0:
                    PlayerPrefs.SetString("SceneToLoad", "Area0");
                    PlayerPrefs.SetInt("GameLevel", 0);
                    PlayerPrefs.SetString("SceneFromLoad", "Lore");
                    GameEvents.LoadScene.Invoke("Loading");
                    break;
                case 1:
                    PlayerPrefs.SetString("SceneToLoad", "Area0");
                    PlayerPrefs.SetInt("GameLevel", 1);
                    PlayerPrefs.SetString("SceneFromLoad", "Lore");
                    GameEvents.LoadScene.Invoke("Loading");
                    break;
            }
        }
    }
    IEnumerator CRContinue()
    {
        DisableTouchForContinue();

        yield return _transitionsController.coFadeToBlack(1f);
        _currentDialogue++;
        ShowDialogue();
        yield return _transitionsController.coFadeFromBlack(1f);
    }
    public void ShowDialogue()
    {
        foreach (GameObject g in _sceneTypesObjects)
        {
            g.SetActive(false);
        }
        _sceneTypesObjects[_cinematics[_currentCinematic]._dialogues[_currentDialogue]._dialogueType].SetActive(true);
        StartCoroutine(CrFillText());
        StartCoroutine(CrShowImages());
    }
    IEnumerator CrFillText()
    {
        yield return null;
        _narrativeText.SetText("");

        for (int i = 0; i < _cinematics[_currentCinematic]._dialogues[_currentDialogue]._texts.Count; i++)
        {
            for (int j = 0; j < _cinematics[_currentCinematic]._dialogues[_currentDialogue]._texts[i].Length; j++)
            {
                yield return null;
                _narrativeText.SetText(_narrativeText.text += _cinematics[_currentCinematic]._dialogues[_currentDialogue]._texts[i][j]);
            }
            _narrativeText.SetText(_narrativeText.text += "\n");
            yield return new WaitForSeconds(1.5f);
        }
        yield return new WaitForSeconds(0.5f);
        _touchForContinue.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        EnableTouchForContinue();
    }
    IEnumerator CrShowImages()
    {
        List<Vector2> layersDataFrom = _cinematics[_currentCinematic]._dialogues[_currentDialogue]._layerDataFrom;
        List<Vector2> layersDataTo = _cinematics[_currentCinematic]._dialogues[_currentDialogue]._layerDataTo;
        List<int> layersToMove = _cinematics[_currentCinematic]._dialogues[_currentDialogue]._layerToMove;
        switch (_cinematics[_currentCinematic]._dialogues[_currentDialogue]._dialogueType)
        {
            case 0:
                for (int k = 0; k < 3; k++)
                {
                    layersImageOneImage[k].enabled = false;
                }
                for (float i = 0; i < 8f; i += Time.deltaTime)
                {

                    for (int j = 0; j < layersToMove.Count; j++)
                    {
                        int layerToMove = layersToMove[j];
                        layersImageOneImage[layerToMove].enabled = true;
                        layersImageOneImage[layerToMove].rectTransform.anchoredPosition = Vector3.Lerp(layersDataFrom[j], layersDataTo[j],_animationCurve.Evaluate(i / 8f));
                        yield return null;
                    }
                }
                break;

            case 1:
                for (int k = 0; k < 6; k++)
                {
                    layersImageTwoImages[k].enabled = false;
                }
                for (float i = 0; i < 8f; i += Time.deltaTime)
                {
                    if (i > 2f)
                    {
                        _twoImagesFadeMask.color = Color.Lerp(Color.black, new Color(0, 0, 0, 0), (i - 2f) / 3f);
                    }

                    for (int j = 0; j < layersDataFrom.Count; j++)
                    {
                        int layerToMove = layersToMove[j];
                        layersImageTwoImages[layerToMove].enabled = true;
                        layersImageTwoImages[layerToMove].rectTransform.anchoredPosition = Vector3.Lerp(layersDataFrom[j], layersDataTo[j],_animationCurve.Evaluate(i / 8f));
                    }
                    yield return null;
                }
                break;

            case 2:

                break;

            case 3:

                break;
        }
    }
    void Update()
    {
        if (_canTouch)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Continue();
                }
            }
        }
    }

    public void EnableTouchForContinue()
    {
        _touchForContinue.SetActive(true);
        _canTouch = true;
    }
    public void DisableTouchForContinue()
    {
        _touchForContinue.SetActive(false);
        _canTouch = false;
    }
}
