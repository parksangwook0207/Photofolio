using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private RectTransform rectTrans; // ���� ���� �̾����� ���ο� ���
    [SerializeField] private float moveSpeed; // ����̵��ӵ�

    float screenWidth = 1920;
    // Update is called once per frame
    void Update()
    {
        // ����̵�
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // ����� ������ ������ ����� ��ġ �缳��

        if(rectTrans.anchoredPosition.x <= -screenWidth)
        {
            rectTrans.anchoredPosition = new Vector2(screenWidth, 0);
        }
    }
}
