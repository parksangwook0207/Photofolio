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
        spawnTimer += Time.deltaTime;
        if(spawnTimer > nextSpwanTime)
        {
            spawnTimer = 0f;
            nextSpwanTime = Random.Range(2, 5);
            Instantiate(bgObjs[Random.Range(0, bgObjs.Count)], parent)
                .Init();
        }
    }
}
