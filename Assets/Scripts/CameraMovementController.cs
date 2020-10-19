using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    [SerializeField]
    GameObject _cameraFollowGO;
    [SerializeField]
    Camera _camera;
    Vector2 firstTouchBegan;
    bool _dragging;
    Vector3 _dragSpeed;
    Queue<Vector3> _dragSpeeds;
    [SerializeField]
    Vector2 _minLimits;
    [SerializeField]
    Vector2 _maxLimits;
    void Start()
    {
        _dragSpeeds = new Queue<Vector3>();
    }
    
    void Update()
    {
        if(Input.touchCount > 0)
        {
            if(Input.touchCount == 1)
            {
                
                if(Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    _dragging = false;
                    firstTouchBegan = _camera.ScreenToViewportPoint(Input.GetTouch(0).position);
                    _dragSpeeds = new Queue<Vector3>();
                }
                else
                {

                    Vector2 newPos = (Vector2)_camera.ScreenToViewportPoint(Input.GetTouch(0).position) -  firstTouchBegan;
                    firstTouchBegan = (Vector2)_camera.ScreenToViewportPoint(Input.GetTouch(0).position);
                    Vector3 currentPosition = _cameraFollowGO.transform.position;
                    Vector3 newCurrentPosition = currentPosition + (_cameraFollowGO.transform.forward * -newPos.y * 50) + (_cameraFollowGO.transform.right * -newPos.x * 50);
                    Vector3 _auxDragSpeed = (newCurrentPosition - currentPosition);
                    if (_dragSpeeds.Count == 10)
                    {
                        _dragSpeeds.Dequeue();
                    }
                    _dragSpeeds.Enqueue(_auxDragSpeed);
                    if (Input.GetTouch(0).phase== TouchPhase.Ended)
                    {

                        if (_dragSpeeds.Count == 5)
                        {
                            _dragSpeeds.Dequeue();
                        }
                        _dragSpeeds.Enqueue(_dragSpeed);

                        _dragSpeed = Vector3.zero;
                        foreach(Vector3 dragspd in _dragSpeeds)
                        {
                            _dragSpeed += dragspd;
                        }
                        _dragSpeed = _dragSpeed/(float)_dragSpeeds.Count;
                        _dragging = true;
                    }
                    else
                    {
                        _cameraFollowGO.transform.position = newCurrentPosition;
                    }
                }
            }

        }
        else
        {
            if (_dragging)
            {
                _cameraFollowGO.transform.position += _dragSpeed * Time.deltaTime*50;
                _dragSpeed *= 0.95f;
            }
        }

            _cameraFollowGO.transform.position = new Vector3(Mathf.Min(Mathf.Max(_cameraFollowGO.transform.position.x, 12),30), _cameraFollowGO.transform.position.y, Mathf.Min(Mathf.Max(_cameraFollowGO.transform.position.z, 20), 40)); 
        
       // _cameraFollowGO.transform.position = new Vector3(Mathf.Clamp(_cameraFollowGO.transform.position.x, _minLimits.y, _maxLimits.y), 14, Mathf.Clamp(_cameraFollowGO.transform.position.x, _minLimits.x, _maxLimits.x));
    }
    
}
