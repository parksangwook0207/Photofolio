using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject prefab;
    // Start is called before the first frame update

    float spawnCnt = 1f;
     void Awake()
     {
        InvokeRepeating("Sp", spawnCnt, 0.1f);
     }

    void Sp()
    {
        Instantiate(prefab, parent);
    }
   
}
