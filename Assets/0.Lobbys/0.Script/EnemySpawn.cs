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

        // spawnCnt가 nextspawnCnt 보다 클 시
        if (spawnCnt > nextspawnCnt)
        {
            // spawnCnt를 0으로 세팅후
            spawnCnt = 0f;

            // nextspawnCnt 를 랜덤값으로 5초에서 7초마다 랜덤 세팅후
            nextspawnCnt = Random.Range(5, 7);
            // enemy를 생성
            Instantiate(enemy[Random.Range(0, enemy.Count)], parent);
        }
    }
}
