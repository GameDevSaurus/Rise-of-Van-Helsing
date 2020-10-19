using UnityEngine;
using UnityEditor;
using System;

public class BezierSpline : MonoBehaviour {

	[SerializeField]
	private Vector3[] points;

	[SerializeField]
	private BezierControlPointMode[] modes;

	[SerializeField]
	private bool loop;

    public bool isPlayer;
    public bool isCamera;
    int currentPoint;
#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Color[] colors = new Color[] { Color.red, new Color(0.04f, 0.75f, 0.81f), Color.green };
        
        Color currentColor = colors[isPlayer?1:0];
        if (isCamera)
        {
            currentColor = colors[2];
        }
        Gizmos.color = currentColor;

        for(int i = 0; i< points.Length; i++)
        {
            if(i%3 == 0)
            {
                Gizmos.DrawCube(transform.TransformPoint(GetControlPoint(i)), new Vector3(0.5f, 0.5f, 0.5f));
            }
        }

        Vector3 p0  = transform.TransformPoint(GetControlPoint(0));
        for (int i = 1; i < ControlPointCount; i += 3)
        {
            Vector3 p1 = transform.TransformPoint( GetControlPoint(i));
            Vector3 p2 = transform.TransformPoint(GetControlPoint(i+1));
            Vector3 p3 = transform.TransformPoint(GetControlPoint(i+2));
            Handles.DrawBezier(p0, p3, p1, p2, currentColor, null, 2f);
            p0 = p3;
        }

    }
#endif
    public void Initialize(bool _loop, Vector3[] _points, int[] _modes, bool _isPlayer, bool _isCamera, int _currentPoint)
    {
        points = _points;
        BezierControlPointMode[] newModes = new BezierControlPointMode[_modes.Length];

        for(int i =0; i< _modes.Length; i++)
        {
            newModes[i] = (BezierControlPointMode)_modes[i];
        }
        modes = newModes;
        isPlayer = _isPlayer;
        isCamera = _isCamera;
        currentPoint = _currentPoint;
    }
    public bool Loop {
		get {
			return loop;
		}
		set {
			loop = value;
			if (value == true) {
				modes[modes.Length - 1] = modes[0];
				SetControlPoint(0, points[0]);
			}
		}
	}

    public int MainControlPointsCount
    {
        get
        {
            return (points.Length / 3);
        }
    }
	public int ControlPointCount {
		get {
			return points.Length;
		}
	}

	public Vector3 GetControlPoint (int index) {
		return points[index];
	}

	public void SetControlPoint (int index, Vector3 point) {
		if (index % 3 == 0) {
			Vector3 delta = point - points[index];
			if (loop) {
				if (index == 0) {
					points[1] += delta;
					points[points.Length - 2] += delta;
					points[points.Length - 1] = point;
				}
				else if (index == points.Length - 1) {
					points[0] = point;
					points[1] += delta;
					points[index - 1] += delta;
				}
				else {
					points[index - 1] += delta;
					points[index + 1] += delta;
				}
			}
			else {
				if (index > 0) {
					points[index - 1] += delta;
				}
				if (index + 1 < points.Length) {
					points[index + 1] += delta;
				}
			}
		}
		points[index] = point;
		EnforceMode(index);
	}

	public BezierControlPointMode GetControlPointMode (int index) {
		return modes[(index + 1) / 3];
	}

	public void SetControlPointMode (int index, BezierControlPointMode mode) {
		int modeIndex = (index + 1) / 3;
		modes[modeIndex] = mode;
		if (loop) {
			if (modeIndex == 0) {
				modes[modes.Length - 1] = mode;
			}
			else if (modeIndex == modes.Length - 1) {
				modes[0] = mode;
			}
		}
		EnforceMode(index);
	}

	private void EnforceMode (int index) {
		int modeIndex = (index + 1) / 3;
		BezierControlPointMode mode = modes[modeIndex];
		if (mode == BezierControlPointMode.Free || !loop && (modeIndex == 0 || modeIndex == modes.Length - 1)) {
			return;
		}
		int middleIndex = modeIndex * 3;
		int fixedIndex, enforcedIndex;
		if (index <= middleIndex) {
			fixedIndex = middleIndex - 1;
			if (fixedIndex < 0) {
				fixedIndex = points.Length - 2;
			}
			enforcedIndex = middleIndex + 1;
			if (enforcedIndex >= points.Length) {
				enforcedIndex = 1;
			}
		}
		else {
			fixedIndex = middleIndex + 1;
			if (fixedIndex >= points.Length) {
				fixedIndex = 1;
			}
			enforcedIndex = middleIndex - 1;
			if (enforcedIndex < 0) {
				enforcedIndex = points.Length - 2;
			}
		}

		Vector3 middle = points[middleIndex];
		Vector3 enforcedTangent = middle - points[fixedIndex];
		if (mode == BezierControlPointMode.Aligned) {
			enforcedTangent = enforcedTangent.normalized * Vector3.Distance(middle, points[enforcedIndex]);
		}
		points[enforcedIndex] = middle + enforcedTangent;
	}

	public int CurveCount {
		get {
			return (points.Length - 1) / 3;
		}
	}
    public Vector3 GetPathPointForDistance(int p, float t)
    {
        return Bezier.GetPoint(points[p], points[p + 1], points[p + 2], points[p + 3], t);
    }
    public Vector3 GetPathPoint(int p, float t)
    {
        p = p * 3;
        return transform.TransformPoint(Bezier.GetPoint(points[p], points[p + 1], points[p + 2], points[p + 3], t));
    }
    public Vector3 GetPathPointDirection(int p, float t)
    {
        p = p * 3;

        return (transform.TransformPoint(Bezier.GetFirstDerivative(points[p], points[p + 1], points[p + 2], points[p + 3], t)) - transform.position).normalized;

    }
    public Vector3 GetPoint (float t) {
		int i;
		if (t >= 1f) {
			t = 1f;
			i = points.Length - 4;
		}
		else {
			t = Mathf.Clamp01(t) * CurveCount;
			i = (int)t;
			t -= i;
			i *= 3;
		}
		return transform.TransformPoint(Bezier.GetPoint(points[i], points[i + 1], points[i + 2], points[i + 3], t));
	}
	
	public Vector3 GetVelocity (float t) {
		int i;
		if (t >= 1f) {
			t = 1f;
			i = points.Length - 4;
		}
		else {
			t = Mathf.Clamp01(t) * CurveCount;
			i = (int)t;
			t -= i;
			i *= 3;
		}
		return transform.TransformPoint(Bezier.GetFirstDerivative(points[i], points[i + 1], points[i + 2], points[i + 3], t)) - transform.position;
	}
	
	public Vector3 GetDirection (float t) {
		return GetVelocity(t).normalized;
	}

	public void AddCurve () {
		Vector3 point = points[points.Length - 1];
		Array.Resize(ref points, points.Length + 3);
		point.x += 1f;
		points[points.Length - 3] = point;
		point.x += 1f;
		points[points.Length - 2] = point;
		point.x += 1f;
		points[points.Length - 1] = point;

		Array.Resize(ref modes, modes.Length + 1);
		modes[modes.Length - 1] = modes[modes.Length - 2];
		EnforceMode(points.Length - 4);

		if (loop) {
			points[points.Length - 1] = points[0];
			modes[modes.Length - 1] = modes[0];
			EnforceMode(0);
		}
	}
	public void RemoveCurve()
    {
        Array.Resize(ref points, points.Length - 3);
    }
	public void Reset () {
		points = new Vector3[] {
			new Vector3(1f, 0f, 0f),
			new Vector3(2f, 0f, 0f),
			new Vector3(3f, 0f, 0f),
			new Vector3(4f, 0f, 0f)
		};
		modes = new BezierControlPointMode[] {
			BezierControlPointMode.Free,
			BezierControlPointMode.Free
		};
	}
}