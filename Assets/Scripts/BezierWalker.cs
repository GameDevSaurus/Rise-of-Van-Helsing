using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierWalker : MonoBehaviour
{
    [SerializeField]
    BezierSpline _path;
    [SerializeField]
    float _speed;
    bool moving = false;
    bool _onlyRotateY;
    bool _useRaycast;

    public void SetOnlyRotate(bool or)
    {
        _onlyRotateY = or;
    }
    public void SetUseRaycast(bool useRc)
    {
        _useRaycast = useRc;
    }
    public void Orient()
    {
        if (_useRaycast)
        {
            RaycastHit hit;
            if (Physics.Raycast(_path.GetPathPoint(0, 0), Vector3.down, out hit, 100, 1 << 10))
            {
                transform.position = hit.point;
            }
        }
        else
        {
            transform.position = _path.GetPathPoint(0, 0);
        }

        Vector3 lookAtPos = transform.position + _path.GetPathPointDirection(0, 0);
        if (_onlyRotateY)
        {
            transform.LookAt(new Vector3(lookAtPos.x, transform.position.y, lookAtPos.z));
        }
        else
        {
            transform.LookAt(lookAtPos);
        }
    }
    public void OrientWithTransition(int point)
    {
        Quaternion currentRotation = transform.rotation;
        Vector3 lookAtPos = transform.position + _path.GetPathPointDirection(point, 0);

        transform.LookAt(lookAtPos);
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward);
        transform.rotation = currentRotation;
        for (float i = 0; i < 0.5f; i += Time.deltaTime)
        {
            transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, i / 0.5f);
        }
    }
    public void RCOrient()
    {
        RaycastHit hit;
        if (Physics.Raycast(_path.GetPathPoint(0, 0), Vector3.down, out hit, 100, 1 << 10))
        {
            transform.position = hit.point;
        }

        Vector3 lookAtPos = transform.position + _path.GetPathPointDirection(0, 0);

        transform.LookAt(new Vector3(lookAtPos.x, transform.position.y, lookAtPos.z));
    }
    public void Orient(int point)
    {
        transform.position = _path.GetPathPoint(point, 0);
        Vector3 pos = transform.position + _path.GetPathPointDirection(point, 0);
        if (_onlyRotateY)
        {
            transform.LookAt(new Vector3(pos.x, transform.position.y, pos.z));
        }
        else
        {
            transform.LookAt(pos);
        }

    }
    public int GetPointsCount()
    {
        return _path.MainControlPointsCount;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public float GetSpeed()
    {
        if (moving)
        {
            return _speed;
        }
        else
        {
            return 0;

        }

    }
    public void SetPath(BezierSpline path)
    {
        _path = path;
    }

    void Update()
    {
    }

    public void MoveFullPath()
    {
        StartCoroutine(CoMoveFullPath());
    }

    public IEnumerator CoMoveFullPath()
    {

        for (int i = 0; i < _path.MainControlPointsCount; i++)
        {
            yield return CoMoveOnePoint(i);
        }
    }

    public void MoveOnePoint(int startPoint)
    {
        StartCoroutine(CoMoveOnePoint(startPoint));
    }

    public IEnumerator CoMoveOnePoint(int point)
    {
        while (_speed == 0)
        {
            yield return null;
        }
        float distance = 0;
        for (int i = 0; i < 10; i++)
        {
            Vector3 o = _path.GetPathPoint(point, i / 10f);
            Vector3 d = _path.GetPathPoint(point, (i + 1) / 10f);
            float dist = (d - o).magnitude;
            float next = (i + 1) / 10f;
            distance += dist;
        }
        float timeToComplete = distance / _speed;
        float speedAtStartPoint = _speed;

        moving = true;
        for (float i = 0; i < timeToComplete; i += CurrentSceneController._currentGameSpeed * Time.deltaTime * (_speed / speedAtStartPoint))
        {

            if (_useRaycast)
            {
                RaycastHit hit;
                if (Physics.Raycast(_path.GetPathPoint(point, i / timeToComplete), Vector3.down, out hit, 100, 1 << 10))
                {
                    transform.position = hit.point;
                }
            }
            else
            {
                transform.position = _path.GetPathPoint(point, i / timeToComplete);
            }
            Vector3 pos = transform.position + _path.GetPathPointDirection(point, i / timeToComplete);
            if (_onlyRotateY)
            {
                transform.LookAt(new Vector3(pos.x, transform.position.y, pos.z));
            }
            else
            {
                transform.LookAt(pos);
            }
            yield return null;
        }
        if (_useRaycast)
        {
            RaycastHit hit;
            if (Physics.Raycast(_path.GetPathPoint(point, 1 / timeToComplete), Vector3.down, out hit, 100, 1 << 10))
            {
                transform.position = hit.point;
            }
        }
        else
        {
            transform.position = _path.GetPathPoint(point, 1);
        }

        moving = false;
    }
    public IEnumerator CoMoveOnePointNoLook(int point)
    {
        while (_speed == 0)
        {
            yield return null;
        }
        float distance = 0;
        for (int i = 0; i < 10; i++)
        {
            Vector3 o = _path.GetPathPoint(point, i / 10f);
            Vector3 d = _path.GetPathPoint(point, (i + 1) / 10f);
            float dist = (d - o).magnitude;
            float next = (i + 1) / 10f;
            distance += dist;
        }
        float timeToComplete = distance / _speed;
        float speedAtStartPoint = _speed;

        moving = true;
        for (float i = 0; i < timeToComplete; i += CurrentSceneController._currentGameSpeed * Time.deltaTime * (_speed / speedAtStartPoint))
        {
            if (_useRaycast)
            {
                RaycastHit hit;
                if (Physics.Raycast(_path.GetPathPoint(point, i / timeToComplete), Vector3.down, out hit, 100, 1 << 10))
                {
                    transform.position = hit.point;
                }
            }
            else
            {
                transform.position = _path.GetPathPoint(point, i / timeToComplete);
            }
            Vector3 pos = transform.position + _path.GetPathPointDirection(point, i / timeToComplete);

            yield return null;
        }
        if (_useRaycast)
        {
            RaycastHit hit;
            if (Physics.Raycast(_path.GetPathPoint(point, 1 / timeToComplete), Vector3.down, out hit, 100, 1 << 10))
            {
                transform.position = hit.point;
            }
        }
        else
        {
            transform.position = _path.GetPathPoint(point, 1);
        }

        moving = false;
    }

}
