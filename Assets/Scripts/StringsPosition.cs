using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringsPosition : MonoBehaviour
{
    [SerializeField]
    LineRenderer leftRope, rightRope;
    [SerializeField]
    GameObject leftRopeBase, rightRopeBase;
    [SerializeField]
    GameObject leftRopeEnd, rightRopeEnd;
    void Start()
    {
        
    }

    
    void LateUpdate()
    {

        leftRope.SetPosition(0, leftRopeBase.transform.position);
        leftRope.SetPosition(1, leftRopeEnd.transform.position);

        rightRope.SetPosition(0, rightRopeBase.transform.position);
        rightRope.SetPosition(1, rightRopeEnd.transform.position);

    }
}
