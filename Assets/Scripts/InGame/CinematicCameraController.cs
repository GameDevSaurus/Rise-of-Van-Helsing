using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class CinematicCameraController : MonoBehaviour
{

    [SerializeField]
    GameObject _cinematicCamera;
    [SerializeField]
    GameObject _cinematicCameraPivot;

    BezierSpline path;
    float originalSpeed = 20;
    float currentSpeed;
    bool updated = false;
    bool ready;
    GameObject _player;
    bool done;

    public void SetPlayer(GameObject player)
    {
        _player = player;
    }
    public void SetPath(BezierSpline p)
    {
        path = p;
    }
    //public void SetPlayableLevel(PlayableLevel pl)
    //{
    //    playableLevel = pl;
    //}

    IEnumerator coMove(int point)
    {
        float distance = 0;
        for (int i = 0; i < 10; i++)
        {
            Vector3 o = path.GetPathPoint(point, i / 10f);
            Vector3 d = path.GetPathPoint(point, (i + 1) / 10f);
            float dist = (d - o).magnitude;
            float next = (i + 1) / 10f;
            distance += dist;
        }
        float timeToComplete = distance / currentSpeed;

        for (float i = 0; i < timeToComplete; i += Time.deltaTime )
        {
            _cinematicCameraPivot.transform.position = path.GetPathPoint(point,1-( i / timeToComplete));
            _cinematicCameraPivot.transform.LookAt(_cinematicCameraPivot.transform.position + path.GetPathPointDirection(point,1-( i / timeToComplete)));
            if (!updated)
            {
                updated = true;

            }
            yield return null;
        }
        _cinematicCameraPivot.transform.position = path.GetPathPoint(point, 0);
        if (point > 0)
        {
            point--;
            StartCoroutine(coMove(point));
        }
        else
        {
            _cinematicCameraPivot.transform.LookAt(_cinematicCameraPivot.transform.position + path.GetDirection(0));
            ready = true;
        }
        /*
        for(float i = 0; i< 5f; i += Time.deltaTime)
        {
            transform.position = path.GetPoint(1 - (i / 3f));
            transform.LookAt(transform.position + path.GetDirection(1 - (i / 3f)));
            if (!updated)
            {
                updated = true;
                cc.transform.position = transform.position;
                cc.transform.rotation = transform.rotation;
            }
            yield return null;
        }
        */
        //transform.position = path.GetPoint(0);

    }


    void Start()
    {
        currentSpeed = originalSpeed;
        Move(path.MainControlPointsCount-1);
        _cinematicCamera.transform.position = path.GetPoint(1f);
        _cinematicCamera.transform.LookAt(_cinematicCamera.transform.position + path.GetDirection(0.98f));
    }
    public void Move(int originPoint)
    {
        StartCoroutine(coMove(originPoint));
    }
    void Update()
    {
        if (updated )
        {
            if (ready)
            {
                _cinematicCamera.transform.position = Vector3.Lerp(_cinematicCamera.transform.position, _cinematicCameraPivot.transform.position, Time.deltaTime*2);
                _cinematicCamera.transform.rotation = Quaternion.Slerp(_cinematicCamera.transform.rotation, _cinematicCameraPivot.transform.rotation, Time.deltaTime*2);
                if (Vector3.Distance(_cinematicCamera.transform.position, transform.position) < 0.1f)
                {
                    if (!done)
                    {
                        done = true;
                        _cinematicCamera.transform.position = transform.position;
                        _cinematicCamera.transform.rotation = transform.rotation;
                        ready = true;
                        _cinematicCamera.SetActive(false);
                        _player.SetActive(true);
                        //playableLevel.Initialize();
                        //UIManager uim = FindObjectOfType<UIManager>();
                        //uim.HideNarrativeBars();
                        //uim.FastAppear();
                        //LevelDataController.LevelData currentLevelData = LevelDataController.GetLevelInfo(PlayerPrefs.GetInt("GameLevel"));
                        //string levelInstructions= "";
                    }
                }
            }
            else
            {
                _cinematicCamera.transform.position = Vector3.Lerp(_cinematicCamera.transform.position, _cinematicCameraPivot.transform.position, Time.deltaTime*2);
                _cinematicCamera.transform.rotation = Quaternion.Slerp(_cinematicCamera.transform.rotation, _cinematicCameraPivot.transform.rotation, Time.deltaTime);
            }
        }
    }
}
