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


    private RectTransform rectTrans;

    private float spawnX = 0;
    public bool isRemove = false;

    public void Init()
    {
        rectTrans = GetComponent<RectTransform>();
        spawnX = Screen.width;

        rectTrans.anchoredPosition = new Vector2(spawnX, startY);
        
        // 스케일 변경
        float scale = Random.Range(scaleSX, scaleEX);
        rectTrans.localScale = new Vector2(scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        if(rectTrans.anchoredPosition.x < removeX)
        {
            if(isRemove)
                Destroy(gameObject);
            else
            {
                int y = (int)Random.Range(startY, endY);
                rectTrans.anchoredPosition = new Vector2(spawnX, y);
            }
        }

        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
