using UnityEditor;
using UnityEngine;
using System;
[CustomEditor(typeof(BezierSpline))]
public class BezierSplineInspector : Editor {

	private const int stepsPerCurve = 10;
	private const float directionScale = 0.5f;
	private const float handleSize = 0.04f;
	private const float pickSize = 0.06f;

	private static Color[] modeColors = {
		Color.white,
		Color.yellow,
		Color.cyan
	};
    GameObject g;
    private void OnEnable()
    {
        //SceneView.duringSceneGui += MyOnSceneGUI;
    }
    
    private BezierSpline spline;
	private Transform handleTransform;
	private Quaternion handleRotation;
	private int selectedIndex = -1;
    bool isPlayer=false;
    bool isCamera = false;
    public override void OnInspectorGUI () {
		spline = target as BezierSpline;
        
		EditorGUI.BeginChangeCheck();
		bool loop = EditorGUILayout.Toggle("Loop", spline.Loop);
        isPlayer = EditorGUILayout.Toggle("IsPlayer", spline.isPlayer);
        isCamera = EditorGUILayout.Toggle("IsCamera", spline.isCamera);
        if (EditorGUI.EndChangeCheck()) {
			Undo.RecordObject(spline, "Toggle Loop");
			EditorUtility.SetDirty(spline);
			spline.Loop = loop;
            spline.isPlayer = isPlayer;
            spline.isCamera = isCamera;
		}
		if (selectedIndex >= 0 && selectedIndex < spline.ControlPointCount) {
			DrawSelectedPointInspector();
		}
		if (GUILayout.Button("Add Curve")) {
			Undo.RecordObject(spline, "Add Curve");
			spline.AddCurve();
			EditorUtility.SetDirty(spline);
		}
        if (GUILayout.Button("Remove Curve"))
        {
            Undo.RecordObject(spline, "Remove Curve");
            spline.RemoveCurve();
            EditorUtility.SetDirty(spline);
        }
    }

	private void DrawSelectedPointInspector() {
		GUILayout.Label("Selected Point");
		EditorGUI.BeginChangeCheck();
		Vector3 point = EditorGUILayout.Vector3Field("Position", spline.GetControlPoint(selectedIndex));
		if (EditorGUI.EndChangeCheck()) {
			Undo.RecordObject(spline, "Move Point");
			EditorUtility.SetDirty(spline);
			spline.SetControlPoint(selectedIndex, point);
		}
		EditorGUI.BeginChangeCheck();
		BezierControlPointMode mode = (BezierControlPointMode)EditorGUILayout.EnumPopup("Mode", spline.GetControlPointMode(selectedIndex));
		if (EditorGUI.EndChangeCheck()) {
			Undo.RecordObject(spline, "Change Point Mode");
			spline.SetControlPointMode(selectedIndex, mode);
			EditorUtility.SetDirty(spline);
		}
	}
    private void MyOnSceneGUI(SceneView sceneview)
    {
        Vector3 p0 = ShowPoint(0, 6, isPlayer? Color.red : Color.cyan);

        /*
        spline = target as BezierSpline;
        handleTransform = spline.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ?
            handleTransform.rotation : Quaternion.identity;

        for (int i = 1; i < spline.ControlPointCount; i += 3)
        {
            Vector3 p1 = ShowPoint(i, 2, Color.green);
            Vector3 p2 = ShowPoint(i + 1, 2, Color.green);
            Vector3 p3 = ShowPoint(i + 2, 6, Color.red);

            Handles.color = Color.gray;
            Handles.DrawLine(p0, p1);
            Handles.DrawLine(p2, p3);

            Handles.DrawBezier(p0, p3, p1, p2, Color.red, null, 4f);
            p0 = p3;
        }*/
        //ShowDirections();
    }
    private void OnSceneGUI () {
		spline = target as BezierSpline;
		handleTransform = spline.transform;
		handleRotation = Tools.pivotRotation == PivotRotation.Local ?
			handleTransform.rotation : Quaternion.identity;

        Color c = isPlayer ? Color.cyan : Color.red;
        if (isCamera)
        {
            c = Color.green;
        }

        Vector3 p0 = ShowPoint(0,4, c);
		for (int i = 1; i < spline.ControlPointCount; i += 3) {
			Vector3 p1 = ShowPoint(i, 2, Color.green);
			Vector3 p2 = ShowPoint(i + 1, 2,Color.green);
			Vector3 p3 = ShowPoint(i + 2,4,c);
			
			Handles.color = Color.gray;
			Handles.DrawLine(p0, p1);
			Handles.DrawLine(p2, p3);
			
			Handles.DrawBezier(p0, p3, p1, p2, c, null, 4f);
			p0 = p3;
		}
		ShowMyDirections();
	}
    private void ShowMyDirections()
    {
        for (int j = 0; j < spline.CurveCount; j++)
        {
            Handles.color = Color.white;
            Vector3 point = spline.GetPathPoint(0,0f);
            Handles.DrawLine(point, point + spline.GetPathPointDirection(0,0f) * directionScale);
            int steps = stepsPerCurve * spline.CurveCount;

            for (int i = 1; i <= steps; i++)
            {
                point = spline.GetPathPoint(j, i / (float)steps);
                Handles.DrawLine(point, point + spline.GetPathPointDirection(j, i / (float)steps) * directionScale);
            }
        }
    }
    private void ShowDirections () {
		Handles.color = Color.green;
		Vector3 point = spline.GetPoint(0f);
		Handles.DrawLine(point, point + spline.GetDirection(0f) * directionScale);
		int steps = stepsPerCurve * spline.CurveCount;
		for (int i = 1; i <= steps; i++) {
			point = spline.GetPoint(i / (float)steps);
			Handles.DrawLine(point, point + spline.GetDirection(i / (float)steps) * directionScale);
		}
	}
    public void MyShowPoint(int index)
    {
        Vector3 point = handleTransform.TransformPoint(spline.GetControlPoint(index));
        Handles.DotHandleCap(0,point,handleRotation,6,EventType.Repaint);
        //Handles.Button(point, handleRotation, 6,6, Handles.CubeCap);
    }
	private Vector3 ShowPoint (int index) {
		Vector3 point = handleTransform.TransformPoint(spline.GetControlPoint(index));
		float size = HandleUtility.GetHandleSize(point);
		if (index == 0) {
			size *= 2f;
		}
		Handles.color = modeColors[(int)spline.GetControlPointMode(index)];
		if (Handles.Button(point, handleRotation, size * handleSize, size * pickSize, Handles.DotCap)) {
			selectedIndex = index;
			Repaint();
		}
		if (selectedIndex == index) {
			EditorGUI.BeginChangeCheck();
			point = Handles.DoPositionHandle(point, handleRotation);
			if (EditorGUI.EndChangeCheck()) {
				Undo.RecordObject(spline, "Move Point");
				EditorUtility.SetDirty(spline);
				spline.SetControlPoint(index, handleTransform.InverseTransformPoint(point));
			}
		}
		return point;
	}
    private Vector3 ShowPoint(int index,float s, Color c)
    {
        Vector3 point = handleTransform.TransformPoint(spline.GetControlPoint(index));
        float size = HandleUtility.GetHandleSize(point);
        size = s;
        Handles.color = c;
        if (Handles.Button(point, handleRotation, size * handleSize, size * pickSize, Handles.DotCap))
        {
            selectedIndex = index;
            Repaint();
        }
        if (selectedIndex == index)
        {
            EditorGUI.BeginChangeCheck();
            point = Handles.DoPositionHandle(point, handleRotation);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(spline, "Move Point");
                EditorUtility.SetDirty(spline);
                spline.SetControlPoint(index, handleTransform.InverseTransformPoint(point));
            }
        }
        return point;
    }
}