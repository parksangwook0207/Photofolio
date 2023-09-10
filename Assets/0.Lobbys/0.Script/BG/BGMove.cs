using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private RectTransform rectTrans; // 현재 배경과 이어지는 새로운 배경
    [SerializeField] private float moveSpeed; // 배경이동속도

    
    float screenWidth = 1920;
    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        

        if(rectTrans.anchoredPosition.x <= -screenWidth)
        {
            rectTrans.anchoredPosition = new Vector2(screenWidth, 0);
        }
    }
}
