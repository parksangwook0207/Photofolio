using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> enemy = new List<GameObject>();
    [SerializeField] private Transform parent;

    // spawnCnt 를 0으로 세팅
    float spawnCnt = 0f;

    // nextspawnCnt를 0으로 세팅
    float nextspawnCnt = 0f;

    // Update is called once per frame
    void Update()
    {
        // spawnCnt를 시간마다 중첩
        spawnCnt += Time.deltaTime;

        if (spawnCnt > nextspawnCnt)
        {
            spawnCnt = 0f;
            nextspawnCnt = Random.Range(2, 5);
            Instantiate(enemy[Random.Range(0, enemy.Count)], parent);
        }
    }
}
