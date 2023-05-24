using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    
    [SerializeField] private float startY = 150;
    [SerializeField] private float endY = 150;
    [SerializeField] private float speed = 10;
    [SerializeField] private float removeX = -300;
    [SerializeField] private float scaleSX = 1f;
    [SerializeField] private float scaleEX = 1f;

    // RectTransform 호출후 rectTrans라는 이름으로 세팅
    private RectTransform rectTrans;

    // spawnX 를 0으로 세팅
    private float spawnX = 0;

    // isRemove 를 처음부터 false 로 세팅
    public bool isRemove = false;

    public void Init()
    {
        //  rectTrans 는 RectTransform 를 가져온다.
        rectTrans = GetComponent<RectTransform>();

        // 스크린의 값을 0으로 세팅
        spawnX = Screen.width;

        // anchoredPosition = 앵커가 없는 포지션값
        // rectTrans.anchoredPosition 의 백터값을 0, 150으로 설정
        rectTrans.anchoredPosition = new Vector2(spawnX, startY);
        
        // 스케일 변경
        float scale = Random.Range(scaleSX, scaleEX);
        rectTrans.localScale = new Vector2(scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        // rectTrans.anchoredPosition.x 가 -300보다 클 때
        if (rectTrans.anchoredPosition.x > removeX)
        {
            // isremove 가 불일때 게임오브젝트를 삭제
            if (isRemove)
            {
                Destroy(gameObject);
            }
            else
            {
                // y의 값을 startY~endY까지 랜덤으로 세팅
                int y = (int)Random.Range(startY, endY);

                //rectTrans.anchoredPosition 의 축을 spawnX , y 로 세팅
                rectTrans.anchoredPosition = new Vector2(spawnX, y);
            }
        }
        // 위치를 왼쪽을 시간마다 이동하되 일정한 스피드를 중첩
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
