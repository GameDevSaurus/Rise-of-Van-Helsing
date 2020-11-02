using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    float _touchLeftSideLimit = 0.6f;
    int _movementTouchIndex;
    float _originalFOV;
    Camera _camera;
    [SerializeField]
    Vector2 _minFreedom;
    [SerializeField]
    Vector2 _maxFreedom;
    [SerializeField]
    Transform _weaponPivot;
    public float _sensibility=1f;
    public void Die()
    {
        StartCoroutine(CoDie());
    }

    IEnumerator CoDie()
    {
        for(float i = 0; i< 3f; i += Time.deltaTime)
        {
            yield return null;
            transform.parent.transform.localPosition = Vector3.Lerp(new Vector3(0, 2.5f, 0), new Vector3(0, 1.5f, 0), i / 3f);
        }
    }
    public void SetFieldOfView(float newFieldOfView)
    {
        StartCoroutine(coChangeFieldOfView(newFieldOfView));
    }

    IEnumerator coChangeFieldOfView(float newFoV)
    {
        for (float i = 0; i < 0.25f; i += Time.deltaTime)
        {
            yield return null;
            _camera.fieldOfView = _originalFOV + (newFoV - _originalFOV) * i / 0.25f;
        }
    }
    public void ReturnFieldOfView()
    {
        StartCoroutine(CoReturnToOriginalFieldOfView());
    }
    IEnumerator CoReturnToOriginalFieldOfView()
    {
        float newFov = _camera.fieldOfView;

        for (float i = 0; i < 0.5f; i += Time.deltaTime)
        {
            yield return null;
            _camera.fieldOfView = newFov + (_originalFOV - newFov) * i / 0.5f;
        }
    }
    void Start()
    {
        _sensibility = 1f;
        _camera = GetComponent<Camera>();
        _originalFOV = _camera.fieldOfView;
    }
    public void Center()
    {
        StartCoroutine(CoCenter(0.5f));
    }
    public void Center(float transitionTime)
    {
        StartCoroutine(CoCenter(transitionTime));
    }

    IEnumerator CoCenter(float transitionDuration)
    {
        Quaternion orig = transform.localRotation;
        Quaternion dest = Quaternion.identity;
        
        for(float i = 0; i< transitionDuration; i += Time.deltaTime)
        {
            transform.localRotation = Quaternion.Slerp(orig, dest, i / transitionDuration);
            yield return null;
        }
        transform.localRotation = Quaternion.identity;
    }

    void Update()
    {
        bool isTouchingForMovement = false;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector2 normalizedTouchPos = new Vector2();
            Vector2 touchPos = Input.GetTouch(i).position;
            normalizedTouchPos = new Vector2(touchPos.x / Screen.width, touchPos.y / Screen.height);
            if (normalizedTouchPos.x < _touchLeftSideLimit)
            {
                isTouchingForMovement = true;
                _movementTouchIndex = i;
            }
        }

        if (isTouchingForMovement)
        {
            float rotX = transform.localRotation.eulerAngles.x;
            float rotY = transform.localRotation.eulerAngles.y;
            Vector2 movingTouchDeltaPos = Input.GetTouch(_movementTouchIndex).deltaPosition;
            Vector2 normalizedDeltaPosition = new Vector2(movingTouchDeltaPos.x / Screen.width, movingTouchDeltaPos.y / Screen.height);

            float deltaX = -normalizedDeltaPosition.y * 100;
            float deltaY = normalizedDeltaPosition.x * 100;

            //deltaX *= UserDataController.GetSensibility() * _sensibility;
            //deltaY *= UserDataController.GetSensibility() * _sensibility;


            rotX += deltaX;
            rotY += deltaY;

            if (rotX > 180)
            {
                rotX = rotX - 360;
            }
            if (rotY > 180)
            {
                rotY = rotY - 360;
            }

            Quaternion currentRotation = Quaternion.Euler(new Vector3(Mathf.Max(_minFreedom.x, Mathf.Min(_maxFreedom.x, rotX)), Mathf.Max(_minFreedom.y, Mathf.Min(_maxFreedom.y, rotY)), 0f));
            transform.localRotation = currentRotation;

        }
    }
    void LateUpdate()
    {
        _weaponPivot.transform.rotation = Quaternion.Slerp(_weaponPivot.transform.rotation, transform.rotation, Time.deltaTime * 20);
    }
}
