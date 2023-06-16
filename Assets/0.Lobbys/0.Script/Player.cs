using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private List<Sprite> moveSprite;
    [SerializeField] private List<Sprite> jumpSprite;
    

    private SpriteAnimation sa;
    private Rigidbody2D rigid;

    //public Animator anim;
  
    public float jumppower = 500f;

    bool isJump = false;
    bool isPlayJump = false;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
       
        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveSprite, 0.1f);
        //anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Mathf.Abs(rigid.velocity.x) < 0.5)
        {
            anim.SetBool("isWalk", false);
        }
        else
        {
            anim.SetBool("isWalk", true);
        }
        */

        RaycastHit2D raycast = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask(""));
        if (raycast.collider != null)
        {
            Debug.Log(raycast.collider.name);
        }

        //AddForce : AddForce(방향 * 힘, 힘의 종류)
        if (Input.GetKeyDown(KeyCode.Space) && isJump) //!anim.GetBool("isWalk"))
        {
            Debug.Log("Jump");
            //rigid.AddForce(transform.up * jumppower, ForceMode2D.Impulse);
            isPlayJump = true;
            //sa.SetSprite(jumpSprite, 0.1f);
            //anim.SetBool("isJump", true);
        }
        if (isPlayJump)
        {
            Vector2 vec2 = transform.localPosition;
            vec2.y += 170;
            //시간이 지남에 따라 GameObject를 현재 위치에서 대상으로 이동
            transform.localPosition = Vector2.Lerp(transform.localPosition, vec2, Time.deltaTime * 1.5f);           
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else if (coll.gameObject.CompareTag("Bottom"))
        {
            isJump = true;
            isPlayJump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            isJump = false;
        }
    }
}
