using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private Transform temMove; // 현재 배경과 이어지는 새로운 배경
    [SerializeField] private float bgDis; // 배경간의 거리
    [SerializeField] private float moveSpeed; // 배경이동속도
    [SerializeField] private Vector3 moveDirection; // 배경이 이동하는 위치



    // Update is called once per frame
    void Update()
    {
        // 배경이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 배경이 설정된 범위를 벗어나면 위치 재설정
        if (transform.position.x <= -bgDis)
        {
            transform.position = temMove.position - moveDirection * bgDis;
        }
    }
}
