using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    Vector3 _rotationPerSecond;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotationPerSecond * Time.deltaTime);
    }
}
