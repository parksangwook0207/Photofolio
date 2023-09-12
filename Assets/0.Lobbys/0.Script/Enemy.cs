using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private float startY = 150;
    [SerializeField] private float removeX = -100;
    [SerializeField] private List<Sprite> moveSprite;

    private RectTransform rect;
    private SpriteAnimation sa;

    public int speed = 10;
    

    private void Start()
    {
        rect = GetComponent<RectTransform>();
        sa = GetComponent<SpriteAnimation>();

        sa.SetSprite(moveSprite, 0.1f);
    }

    void Update()
    {
        if (rect.anchoredPosition.x < removeX)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

   
}
