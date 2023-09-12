using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] private RectTransform rectTrans;
    [SerializeField] private float moveSpeed; 

    
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
