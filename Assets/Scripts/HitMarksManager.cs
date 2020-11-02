using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitMarksManager : MonoBehaviour
{
    [SerializeField]
    Image[] hitMarksImages;
    [SerializeField]
    Sprite[] hitMarksSprites;
    int currentHitMark;
    [SerializeField]
    AnimationCurve bloodSplatDissappearCurve;
    [SerializeField]
    RectTransform canvasTransform;
    public void ShowHitMark(EnemyAttackTypes type, EnemyAttackDirections direction, Vector3 position)
    {
        hitMarksImages[currentHitMark].rectTransform.localRotation = Quaternion.Euler(0, 0,0);
        hitMarksImages[currentHitMark].rectTransform.localScale = new Vector3(1, 1, 1);
        switch (type)
        {
            case EnemyAttackTypes.Bite:
                hitMarksImages[currentHitMark].sprite = hitMarksSprites[1];
                hitMarksImages[currentHitMark].overrideSprite = hitMarksSprites[1];
                break;

            case EnemyAttackTypes.Scratch:
                if(direction == EnemyAttackDirections.Left2Right)
                {
                    hitMarksImages[currentHitMark].rectTransform.localScale = new Vector3(-1,1,1);
                }
                hitMarksImages[currentHitMark].sprite = hitMarksSprites[0];
                hitMarksImages[currentHitMark].overrideSprite = hitMarksSprites[0];
                break;
        }
        Vector2 viewportPosition = Camera.main.WorldToViewportPoint(position);

        Vector2 pos = new Vector2(((viewportPosition.x * canvasTransform.sizeDelta.x) - (canvasTransform.sizeDelta.x * 0.5f)), ((viewportPosition.y * canvasTransform.sizeDelta.y) - (canvasTransform.sizeDelta.y * 0.5f)));
                hitMarksImages[currentHitMark].rectTransform.localPosition = new Vector3(Mathf.Max(Mathf.Min(pos.x, 960), -960), Mathf.Max(Mathf.Min(pos.y, 540), -540), 0);
        StartCoroutine(coAnimateMark(hitMarksImages[currentHitMark]));
        currentHitMark++;
        currentHitMark = currentHitMark % hitMarksImages.Length;
    }
    IEnumerator coAnimateMark(Image im)
    {
        im.enabled = true;
        Color originalColor = new Color(0.28f, 0.28f, 0.28f);
        Color transparentColor = new Color(0.28f, 0.28f, 0.28f, 0f);

        for (float i = 0; i < 0.5f; i += Time.deltaTime)
        {
            im.color = Color.Lerp(originalColor, transparentColor, bloodSplatDissappearCurve.Evaluate(i/0.5f));
            yield return 0;

        }
        im.color = transparentColor;
        im.enabled = false;
    }

    public void ShowBloodSplat()
    {
        StartCoroutine(coAnimateSplat());
    }

    IEnumerator coAnimateSplat()
    {
        Color originalColor = new Color(0.28f, 0.28f, 0.28f);
        Color transparentColor = new Color(0.28f, 0.28f, 0.28f, 0f);
        hitMarksImages[currentHitMark].sprite = hitMarksSprites[2];
        hitMarksImages[currentHitMark].overrideSprite = hitMarksSprites[2];
        hitMarksImages[currentHitMark].rectTransform.localScale = Vector3.zero;
        hitMarksImages[currentHitMark].rectTransform.localPosition = new Vector3(Random.Range(-480, 480), Random.Range(-270, 270), 0);
        hitMarksImages[currentHitMark].rectTransform.localRotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        hitMarksImages[currentHitMark].enabled = true;
        hitMarksImages[currentHitMark].color = originalColor;
        for (float i = 0; i < 0.1f; i += Time.deltaTime)
        {
            yield return 0;
            hitMarksImages[currentHitMark].rectTransform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(6, 6, 6), i / 0.2f);
        }
        for (float i = 0; i < 0.5f; i += Time.deltaTime)
        {
            yield return 0;
            hitMarksImages[currentHitMark].rectTransform.localPosition = hitMarksImages[currentHitMark].rectTransform.localPosition + (Vector3.down * 1f) * (i/0.5f);
            hitMarksImages[currentHitMark].color = Color.Lerp(originalColor, transparentColor, bloodSplatDissappearCurve.Evaluate(i/0.5f));
        }
        hitMarksImages[currentHitMark].enabled = false;
        hitMarksImages[currentHitMark].rectTransform.localScale = new Vector3(1, 1, 1);
        currentHitMark++;
        currentHitMark = currentHitMark % hitMarksImages.Length;
    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
