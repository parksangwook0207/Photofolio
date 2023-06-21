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
  
    public float jumppower = 300f;

    bool isJump = false;
    bool isPlayJump = false;
    void Start()
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

       

        //AddForce : AddForce(���� * ��, ���� ����)
        if (Input.GetKeyDown(KeyCode.Space) && isJump) //!anim.GetBool("isWalk"))
        {
            //Debug.Log("Jump");
            
            //rigid.AddForce(transform.up * jumppower, ForceMode2D.Impulse);
            isPlayJump = true;
            //sa.SetSprite(jumpSprite, 0.1f);
            //anim.SetBool("isJump", true);
        }
        if (isPlayJump)
        {
            Vector2 vec2 = transform.localPosition;
            vec2.y += 150;
            //�ð��� ������ ���� GameObject�� ���� ��ġ���� ������� �̵�
            transform.localPosition = Vector2.Lerp(transform.localPosition, vec2, Time.deltaTime * 2f);          
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
