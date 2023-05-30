using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> enemy = new List<GameObject>();
    [SerializeField] private Transform parent;

    
    // spawnCnt �� 0���� ����
    float spawnCnt = 0f;

    // nextspawnCnt�� 0���� ����
    float nextspawnCnt = 0f;

    

    // Update is called once per frame
    void Update()
    {
        // spawnCnt�� �ð����� ��ø
        spawnCnt += Time.deltaTime;

        // spawnCnt�� nextspawnCnt ���� Ŭ ��
        if (spawnCnt > nextspawnCnt)
        {
            // spawnCnt�� 0���� ������
            spawnCnt = 0f;

            // nextspawnCnt �� ���������� 5�ʿ��� 7�ʸ��� ���� ������
            nextspawnCnt = Random.Range(5, 7);
            // enemy�� ����
            Instantiate(enemy[Random.Range(0, enemy.Count)], parent);
        }
    }
}
