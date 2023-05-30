using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private float startY = 180;
    [SerializeField] private float removeX = -60;

    [SerializeField] private List<Sprite> moveCoins;


    public int speed = 10;
    public bool isRemove = false;

    private RectTransform rect;
    private SpriteAnimation sa;


    private void Start()
    {
        rect = GetComponent<RectTransform>();
        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveCoins, 0.3f);
    }
    // Update is called once per frame
    void Update()
    {
        if (rect.anchoredPosition.x < removeX)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
