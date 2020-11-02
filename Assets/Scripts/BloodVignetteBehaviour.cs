using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodVignetteBehaviour : MonoBehaviour
{
    [SerializeField]
    Image blood;
    [SerializeField]
    AnimationCurve bloodDissappearCurve;
    Coroutine bloodCoroutine;
    public void EnableBlood()
    {
        if (bloodCoroutine != null)
        {
            StopCoroutine(bloodCoroutine);
        }
        bloodCoroutine =  StartCoroutine(coAnimateBloodVignette());
    }
    IEnumerator coAnimateBloodVignette()
    {
        Color originalVignetteColor = new Color(blood.color.r, blood.color.g, blood.color.b, 1);
        Color transparentVignetteColor = new Color(blood.color.r, blood.color.g, blood.color.b, 0);
        blood.color = originalVignetteColor;
        blood.enabled = true;
        for (float i = 0; i < 1f; i += Time.deltaTime)
        {
            yield return 0;
            blood.color = Color.Lerp(originalVignetteColor, transparentVignetteColor, bloodDissappearCurve.Evaluate(i));
        }
        blood.enabled = false;
    }

}
