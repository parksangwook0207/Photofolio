using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> enemy = new List<GameObject>();
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
            nextspawnCnt = Random.Range(3, 5);
            Instantiate(enemy[Random.Range(0, enemy.Count)], parent);
        }
    }
}
