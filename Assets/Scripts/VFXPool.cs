using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXPool : MonoBehaviour
{
    [SerializeField]
    ParticleSystem[] vfxPool;
    int currentVFX;

    public void Play(Vector3 pos)
    {
        vfxPool[currentVFX].transform.position = pos;
        vfxPool[currentVFX].Play();
        currentVFX++;
        currentVFX = currentVFX % vfxPool.Length;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
