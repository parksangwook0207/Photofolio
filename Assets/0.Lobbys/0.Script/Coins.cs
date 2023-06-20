using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    [SerializeField] private float startY = 150;
    [SerializeField] private float removeX = -100;
    [SerializeField] private List<Sprite> moveSprite;

    private RectTransform rect;
    private SpriteAnimation sa;
   

    public int speed = 10;
    public bool isRemove = false;

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        sa = GetComponent<SpriteAnimation>();
          
        sa.SetSprite(moveSprite, 0.1f);
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

    public void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Score.coin += 1;
            Destroy(gameObject);
        }
        
    }
}
