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

    // RectTransform ȣ���� rectTrans��� �̸����� ����
    private RectTransform rectTrans;

    // spawnX �� 0���� ����
    private float spawnX = 0;

    // isRemove �� ó������ false �� ����
    public bool isRemove = false;

    public void Init()
    {
        //  rectTrans �� RectTransform �� �����´�.
        rectTrans = GetComponent<RectTransform>();

        // ��ũ���� ���� 0���� ����
        spawnX = Screen.width;

        // anchoredPosition = ��Ŀ�� ���� �����ǰ�
        // rectTrans.anchoredPosition �� ���Ͱ��� 0, 150���� ����
        rectTrans.anchoredPosition = new Vector2(spawnX, startY);
        
        // ������ ����
        float scale = Random.Range(scaleSX, scaleEX);
        rectTrans.localScale = new Vector2(scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        // rectTrans.anchoredPosition.x �� -300���� Ŭ ��
        if (rectTrans.anchoredPosition.x > removeX)
        {
            // isremove �� ���϶� ���ӿ�����Ʈ�� ����
            if (isRemove)
            {
                Destroy(gameObject);
            }
            else
            {
                // y�� ���� startY~endY���� �������� ����
                int y = (int)Random.Range(startY, endY);

                //rectTrans.anchoredPosition �� ���� spawnX , y �� ����
                rectTrans.anchoredPosition = new Vector2(spawnX, y);
            }
        }
        // ��ġ�� ������ �ð����� �̵��ϵ� ������ ���ǵ带 ��ø
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
