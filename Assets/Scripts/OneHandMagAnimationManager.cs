using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHandMagAnimationManager : MonoBehaviour
{
    [SerializeField]
    OneHandMag oneHandMag;
    public void Shoot()
    {
        oneHandMag.Shoot();
    }
    public void NextArrow()
    {
        oneHandMag.Next();
    }
    public void RefillArrows()
    {
        oneHandMag.Reload();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
