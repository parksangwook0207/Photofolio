using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGObjectSpwan : MonoBehaviour
{
    [SerializeField] List<BackGround> bgObjs = new List<BackGround>();
    [SerializeField] private Transform parent;
    float spawnTimer = 0;
    float nextSpwanTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // spawnTimer 를 시간마다 중첩
        spawnTimer += Time.deltaTime;

        // spawnTimer가 nextSpwanTime 클 때
        if (spawnTimer > nextSpwanTime)
        {

            spawnTimer = 0f;
            //nextSpwanTime 를 2초와 5초사이중 랜덤으로 세팅
            nextSpwanTime = Random.Range(2, 5);

            // 생성) bgObjs 를 랜덤으로 0초부터 bgObjs.Count 세팅 parent로 생성하고 Init
            //       에 접근
            Instantiate(bgObjs[Random.Range(0, bgObjs.Count)], parent)
                .Init();
        }
    }
}
