using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererPool : MonoBehaviour
{
    [SerializeField]
    List<LineRenderer> lrs;
    int currentLR;
    float preferredDistance = 15;
    float preferredMultiplier = 0.05f;

    void Start()
    {
        for(int i = 0; i< lrs.Count; i++)
        {
            lrs[i].enabled = false;
        }   
    }
    public void Shoot(Vector3 start, Vector3 end)
    {
        lrs[currentLR].SetPosition(0, start);
        lrs[currentLR].SetPosition(1, end);
        lrs[currentLR].enabled = true;
        float distance = Mathf.Abs((end - start).magnitude);
        float normalizedDistanceMultiplier = distance / preferredDistance;
        float finalDistanceMultiplier = normalizedDistanceMultiplier * preferredMultiplier;
        lrs[currentLR].widthMultiplier =Mathf.Min(finalDistanceMultiplier,0.05f);
        StartCoroutine(TrailVanish(currentLR));
        currentLR = (currentLR + 1)%lrs.Count;
    }

    public IEnumerator TrailVanish(int lrIndex)
    {
        for (float i = 0; i < 0.4f; i += Time.deltaTime)
        {
            Gradient gr = new Gradient();
            float alphaOpacity0 = i / 0.4f;
            GradientAlphaKey[] gaks = new GradientAlphaKey[]{
                new GradientAlphaKey(0f,0f),
                new GradientAlphaKey(1f-alphaOpacity0,1f)
            };
            gr.SetKeys(gr.colorKeys, gaks);
            lrs[lrIndex].colorGradient = gr;
            yield return 0;
        }
        lrs[lrIndex].enabled = false;
    }
}
