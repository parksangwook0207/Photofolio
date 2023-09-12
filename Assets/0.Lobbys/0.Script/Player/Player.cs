using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private List<Sprite> moveSprite;
    
    private SpriteAnimation sa;
    private Rigidbody2D rigid;

    public float jumppower = 10f;

    bool isJump = false;
    bool isPlayJump = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveSprite, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJump)
        {
            isPlayJump = true;
        }
        
        if (isPlayJump)
        {
            Vector2 vec2 = transform.localPosition;
            vec2.y += 150;
            //시간이 지남에 따라 GameObject를 현재 위치에서 대상으로 이동
            transform.localPosition = Vector2.Lerp(transform.localPosition, vec2, Time.deltaTime * 2f);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            isJump = true;
            isPlayJump = false;
            //Debug.Log(isPlayJump);
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            isJump = false;
            Debug.Log(isJump);
        }
    }
}
