using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkReferenceAnimator : MonoBehaviour
{
    float elapsedTime;
    float speed=1f;
    [SerializeField]
    BezierWalker _bezierWalker;
    void Start()
    {
        
    }

    void Update()
    {
        elapsedTime += Time.deltaTime*speed * _bezierWalker.GetSpeed();
        transform.localPosition = new Vector3((Mathf.Sin(elapsedTime)-0.5f)*0.01f ,((Mathf.Sin((elapsedTime*2) + 0.5f) - 0.5f)*0.01f), 0);
    }
}
