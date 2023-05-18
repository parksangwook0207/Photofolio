using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private Transform temMove; // ���� ���� �̾����� ���ο� ���
    [SerializeField] private float bgDis; // ��氣�� �Ÿ�
    [SerializeField] private float moveSpeed; // ����̵��ӵ�
    [SerializeField] private Vector3 moveDirection; // ����� �̵��ϴ� ��ġ



    // Update is called once per frame
    void Update()
    {
        // ����̵�
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // ����� ������ ������ ����� ��ġ �缳��
        if (transform.position.x <= -bgDis)
        {
            transform.position = temMove.position - moveDirection * bgDis;
        }
    }
}
