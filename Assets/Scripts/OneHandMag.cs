using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneHandMag : MonoBehaviour
{
    [SerializeField]
    List<GameObject> arrows;
    List<Vector3> tr;
    Transform arrowHolder;
    int counter;
    public void Next()
    {
        StartCoroutine(coNext());
    }

    IEnumerator coNext()
    {
        float time = 0.1f;
        List<Vector3> newPositions = new List<Vector3>();
        
        for(float i = 0; i< time; i+=Time.deltaTime)
        {
            yield return 0;
            
            for (int j = counter; j < arrows.Count; j++)
            {
                int first = j - counter + 1;
                int second = j - counter;
                arrows[j].transform.localPosition = Vector3.Lerp(tr[first], tr[second], i/time);
            }
        }
        for (int j = counter; j < arrows.Count; j++)
        {
            arrows[j].transform.localPosition = tr[j-counter];
        }

        counter++;
    }
    public void Shoot()
    {
        arrows[counter-1].GetComponent<MeshRenderer>().enabled = false;
    }

    public void Reload()
    {
        for(int i = 0; i< arrows.Count; i++)
        {
            arrows[i].transform.localPosition = tr[i + 1];
            arrows[i].GetComponent<MeshRenderer>().enabled = true;
            counter = 0;
        }
    }

    void Start()
    {
        tr = new List<Vector3>();
        arrowHolder = transform.GetChild(0);
        for(int i = 0; i< arrowHolder.childCount; i++)
        {
            tr.Add(arrowHolder.GetChild(i).localPosition);
        }
        Next();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)){
            Next();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
}

