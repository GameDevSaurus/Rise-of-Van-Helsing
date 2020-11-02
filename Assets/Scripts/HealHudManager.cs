using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealHudManager : MonoBehaviour
{
    [SerializeField]
    Image[] crossImages;
    [SerializeField]
    Color c;
    void Start()
    {
        
    }
    public void Heal()
    {
        for(int i = 0; i< crossImages.Length; i++)
        {
            StartCoroutine(coHeal(i));
        }  
    }
    
    IEnumerator coHeal(int im)
    {
        yield return new WaitForSeconds(0.5f);
        yield return new WaitForSeconds(Random.Range(0, 1f));
        crossImages[im].enabled = true;
        Color transparent = new Color(c.r, c.g, c.b, 0);
        crossImages[im].transform.localPosition = new Vector3(Random.Range(-750, 750), Random.Range(-450, 450));
        for(float i =0; i< 1; i += Time.deltaTime)
        {
            crossImages[im].rectTransform.localPosition += Vector3.up * 100 * Time.deltaTime;
            crossImages[im].color = Color.Lerp(c, transparent, i);
            yield return 0;
        }
        crossImages[im].transform.localPosition = new Vector3(Random.Range(-750, 750), Random.Range(-450, 450));
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            crossImages[im].rectTransform.localPosition += Vector3.up * 100 * Time.deltaTime;
            crossImages[im].color = Color.Lerp(c, transparent, i);
            yield return 0;
        }
        crossImages[im].enabled = false;
        
    }

}
