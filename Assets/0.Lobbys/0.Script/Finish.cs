using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject finishim;
    [SerializeField] private Transform parent;

    float finishvaule = 30;

    

    // Update is called once per frame
    void Update()
    {
        if (Score.coin == finishvaule)
        {
            Instantiate(finishim, parent);
        }
    }
}
