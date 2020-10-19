using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BezierImporter : MonoBehaviour
{

    [SerializeField]
    bool import;
    BezierSpline _bezierSpline;
    [SerializeField]
    string _importData;
    void Start()
    {
        
    }

    void Update()
    {
        if (import)
        {
            ZoneData z = JsonUtility.FromJson<ZoneData>(_importData);
            GameObject g = new GameObject();
            g.name = z._zoneHolder._name;
            g.transform.position = z._zoneHolder._position;
            g.transform.rotation = Quaternion.Euler(z._zoneHolder._rotation);
            for(int i = 0; i< z._childs.Length; i++)
            {
                GameObject gaux = new GameObject(z._childs[i]._name);
                gaux.transform.SetParent(g.transform);
                gaux.transform.position = z._childs[i]._position;
                gaux.transform.rotation = Quaternion.Euler(z._childs[i]._rotation);
                BezierData b = z._childs[i]._bezierData;
                if (z._childs[i]._bezierData != null)
                {
                    BezierSpline bspline = gaux.AddComponent<BezierSpline>();
                    bspline.Initialize(b.loop,b.points, b.modes, b.isPlayer, b.isCamera, b.currentPoint);
                }
            }
            import = false;

        }
    }
}

[System.Serializable]
public class GameObjectData
{
    public string _name;
    public Vector3 _position;
    public Vector3 _rotation;
    public BezierData _bezierData;

    public GameObjectData(string name, Vector3 position, Vector3 rotation)
    {
        _name = name;
        _position = position;
        _rotation = rotation;
        _bezierData = null;
    }
    public GameObjectData(string name, Vector3 position, Vector3 rotation, BezierData bezierData)
    {
        _name = name;
        _position = position;
        _rotation = rotation;
        _bezierData = bezierData;
    }

}

[System.Serializable]
public class ZoneData
{
    public GameObjectData _zoneHolder;
    public GameObjectData[] _childs;

    public ZoneData(GameObjectData zoneHolder, GameObjectData[] childs)
    {
        _zoneHolder = zoneHolder;
        _childs = childs;
    }

}
[System.Serializable]
public class BezierData
{
    public bool loop;
    public Vector3[] points;
    public int[] modes;

    public bool isPlayer;
    public bool isCamera;
    public int currentPoint;

    public BezierData(bool _loop, Vector3[] _points, int[] _modes, bool _isPlayer, bool _isCamera, int _currentPoint)
    {
        loop = _loop;
        points = _points;
        modes = _modes;
        isPlayer = _isPlayer;
        isCamera = _isCamera;
        currentPoint = _currentPoint;

    }
}
