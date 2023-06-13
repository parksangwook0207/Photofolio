using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> coins = new List<GameObject>();
    [SerializeField] private Transform parent;

    float spawnCnt = 0f;
    float nextspawnCnt = 0f;

    // Update is called once per frame
    void Update()
    {
        spawnCnt += Time.deltaTime;
        if (spawnCnt > nextspawnCnt)
        {
            spawnCnt = 0f;

            nextspawnCnt = Random.Range(2, 5);

            Instantiate(coins[Random.Range(0, coins.Count)], parent);
        }       
    }
}
